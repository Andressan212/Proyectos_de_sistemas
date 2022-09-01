package Modelo;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class ConsultasHistorial {
	Conexion conn = new Conexion();
	Connection usarConexion = null;
	Statement stm = null;
	ResultSet rs = null;
	PreparedStatement ps;

	public void descargarLibro(String tituloLibro, int idUsuario) {
		int idLibro;
		boolean historial;

		try {
			ConsultasLibros libro = new ConsultasLibros(); // BUSCAR idlibro CON EL TITULO
			if (libro.buscarLibro(tituloLibro) != 0) {
				idLibro = libro.buscarLibro(tituloLibro); // Libro encontrado y asignado a la variable idLibro

				historial = buscarHistorialMes(idUsuario);
				if (historial == false) {
					// no hay registro, insertar uno nuevo
					insertarNuevaDescarga(idLibro, idUsuario);
				} else {
					int descDia = obtenerDescargasDia(idUsuario);
					int descMes = obtenerDescargasMes(idUsuario);
					int idLibroEnDB= obtenerIdLibroHoy(idUsuario);
					System.out.println("cantidad dias: " + descDia + " cant mes: " + descMes);
					// verificar si puede realizar la descarga o no
					if (descMes <= 20) {
						if (descDia == 0) {
							insertarDescarga(idUsuario, idLibro);
						
						}
						if (descDia == 1) {
							if(idLibro == idLibroEnDB) {
								actualizarDescarga(idUsuario, idLibro);
							}else {
								insertarDescarga(idUsuario, idLibro);
							}
						} else {
							System.out.println("Se ha vencido el limite de descargas...");
						}

					} else {
						System.out.println("Se ha vencido el limite de descargas por mes");
					}

				}
			} else {
				System.out.println("Titulo de libro no encontrado");
			}

		} catch (Exception e) {
			System.out.println("oops: " + e);
		}
	}

	public int obtenerDescargasDia(int idUsuario) {
		int descargaDia = 0;
		try {
			String consulta = "SELECT cantidadDescargas FROM historialdescarga where  fecha= CURDATE() and idUsuario="
					+ idUsuario;
			stm = usarConexion.createStatement();
			rs = stm.executeQuery(consulta);
			if (rs.next()) {
				descargaDia = rs.getInt(1);
				
			} else {
				descargaDia = 0;
			}
		} catch (Exception e) {
			System.out.println("error al buscar descargas del dia");
		}
		return descargaDia;
	}

	public void insertarDescarga(int idUsuario, int idLibro) {
		try {
			usarConexion = conn.conectar();
			String consulta = "insert into historialdescarga (idLibro,idUsuario, fecha, cantidadDescargas ) VALUES (?,?,?,?)";
			ps = usarConexion.prepareStatement(consulta);
			ps.setObject(1, idLibro);
			ps.setObject(2, idUsuario);
			ps.setObject(3, "CURDATE()");
			ps.setObject(4, 1);
		} catch (Exception e) {
			System.out.println("error insertar descarga: " + e);
		}

	}

	public int obtenerIdLibroHoy(int idUsuario) {
		int idLibroBD = 0;
		try {
			String consulta = "SELECT idLibro FROM historialdescarga where  fecha= CURDATE() and idUsuario="
					+ idUsuario;
			stm = usarConexion.createStatement();
			rs = stm.executeQuery(consulta);
			if (rs.next()) {
				idLibroBD = rs.getInt(1);
							}

		} catch (Exception e) {
			System.out.println("error");
		}

		return idLibroBD;
	}

	public int obtenerDescargasMes(int idUsuario) {
		int descargaMes = 0;
		try {
			String consulta = "SELECT SUM(cantidadDescargas) FROM historialdescarga where  YEAR(fecha)= YEAR(CURDATE()) AND MONTH(fecha) = MONTH(CURDATE()) and idUsuario="
					+ idUsuario;
			stm = usarConexion.createStatement();
			rs = stm.executeQuery(consulta);
			if (rs.next()) {
				descargaMes = rs.getInt(1);
				
			}
		} catch (Exception e) {
			System.out.println("error al buscar descargas del mes");
		}

		return descargaMes;
	}

	public void actualizarDescarga(int idUsuario, int idLibro) {
		try {
			String consulta = "update historialdescarga set cantidadDescargas =? where fecha=CURDATE() and idUsuario=? and idLibro=?";
			usarConexion = conn.conectar();
			ps = usarConexion.prepareStatement(consulta);
			ps.setObject(1, 2);
			ps.setObject(2, idUsuario);
			ps.setObject(3, idLibro);
			ps.executeUpdate();
			System.out.println("¡Descarga exitosa!");
		} catch (Exception e) {
			System.out.println("problemas al sumar descarga");
		}
	}

//String consulta = "update historialdescarga set cantidadDescargas = 2 where fecha = CURDATE() and idUsuario="+ idUsuario;
	public boolean buscarHistorialMes(int idUsuario) {
		boolean registro = false;

		try {
			usarConexion = conn.conectar(); // estamos usando la llave
			String consulta = "SELECT * from historialdescarga where YEAR(fecha) = YEAR(CURDATE()) and MONTH(fecha) = MONTH(CURDATE()) and idUsuario="
					+ idUsuario;// usamos esta consulta...
			stm = usarConexion.createStatement();
			rs = stm.executeQuery(consulta);
			if (rs.next()) {
				registro = true;
				System.out.println("tiene descarga este mes");
			} else {
				System.out.println("no tiene desc. este mes");
			}
		} catch (Exception e) {
			System.out.println("error al buscar historial");

		}
		return registro;
	}

	public void insertarNuevaDescarga(int idLibro, int idUsuario) {
		try {
			usarConexion = conn.conectar();
			String consulta = "insert into historialdescarga (idLibro,idUsuario, fecha, cantidadDescargas ) VALUES (?,?,CURDATE(),?)";
			ps = usarConexion.prepareStatement(consulta);
			ps.setObject(1, idLibro);
			ps.setObject(2, idUsuario);
			ps.setObject(3, 1);

			ps.executeUpdate();
			System.out.println("¡Se insertó un nuevo registro en Historial de Descargas!");

		} catch (Exception e) {
			System.out.println("No se pudo insertar un registro: " + e);
		}

	}

}
