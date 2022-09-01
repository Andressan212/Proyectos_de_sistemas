package Modelo;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Scanner;

public class ConsultasUsuarios {
	Conexion conn = new Conexion();
	Connection usarConexion = null;
	Statement stm = null;
	ResultSet rs = null;
	PreparedStatement ps;

	public void mostrarUsuarios(int jerarquia) {

		if (jerarquia == 1) {

			try {
				usarConexion = conn.conectar(); // estamos usando la llave
				String consulta = "SELECT * FROM usuarios";// usamos esta consulta...
				stm = usarConexion.createStatement();
				rs = stm.executeQuery(consulta); // tenemos toda la inf de usuarios
				while (rs.next()) { // leemos linea por linea

					Usuario usuario = new Usuario();
					// idUsuario, login, clave, nombre, apellido, jerarquia

					usuario.setIdUsuario(rs.getInt(1));
					usuario.setLogin(rs.getString(2));
					usuario.setClave(rs.getString(3));
					usuario.setNombre(rs.getString(4));
					usuario.setApellido(rs.getString(5));
					usuario.setJerarquia(rs.getInt(6));

					System.out.printf("%2d,%10s,%10s,%16s,%16s,$2d%n", usuario.getIdUsuario(), usuario.getLogin(),
							usuario.getClave(), usuario.getNombre(), usuario.getApellido(), usuario.getJerarquia());

				}
			} catch (Exception e) {
				System.out.println("oops: " + e);
			}

		} else {
			System.out.println("usuario no autorizado");
		}

	}

	public void mostrarUsuariosBaja(int jerarquia) {

		if (jerarquia == 1) {

			try {
				usarConexion = conn.conectar(); // estamos usando la llave
				String consulta = "SELECT * FROM usuarios where jerarquia = 4";// usamos esta consulta...
				stm = usarConexion.createStatement();
				rs = stm.executeQuery(consulta); // tenemos toda la inf de usuarios
				while (rs.next()) { // leemos linea por linea

					Usuario usuario = new Usuario();
					// idUsuario, login, clave, nombre, apellido, jerarquia

					usuario.setIdUsuario(rs.getInt(1));
					usuario.setLogin(rs.getString(2));
					usuario.setClave(rs.getString(3));
					usuario.setNombre(rs.getString(4));
					usuario.setApellido(rs.getString(5));
					usuario.setJerarquia(rs.getInt(6));

					System.out.printf("%2d,%10s,%10s,%16s,%16s,$2d%n", usuario.getIdUsuario(), usuario.getLogin(),
							usuario.getClave(), usuario.getNombre(), usuario.getApellido(), usuario.getJerarquia());

				}
				if(!rs.next()) {
					System.out.println("No hay usuarios dados de baja aun");
				}
			} catch (Exception e) {
				System.out.println("oops: " + e);
			}

		} else {
			System.out.println("usuario no autorizado");
		}

	}

	public void mostrarUsuariosSocios(int jerarquia) {

		if (jerarquia == 1) {

			try {
				usarConexion = conn.conectar(); // estamos usando la llave
				String consulta = "SELECT * FROM usuarios where jerarquia = 2";// usamos esta consulta...
				stm = usarConexion.createStatement();
				rs = stm.executeQuery(consulta); // tenemos toda la inf de usuarios
				while (rs.next()) { // leemos linea por linea

					Usuario usuario = new Usuario();
					// idUsuario, login, clave, nombre, apellido, jerarquia

					usuario.setIdUsuario(rs.getInt(1));
					usuario.setLogin(rs.getString(2));
					usuario.setClave(rs.getString(3));
					usuario.setNombre(rs.getString(4));
					usuario.setApellido(rs.getString(5));
					usuario.setJerarquia(rs.getInt(6));

					System.out.printf("%2d,%10s,%10s,%16s,%16s,%2d%n", usuario.getIdUsuario(), usuario.getLogin(),
							usuario.getClave(), usuario.getNombre(), usuario.getApellido(), usuario.getJerarquia());

				}
				if(!rs.next()) {
					System.out.println("No hay usuarios dados de alta aun");
				}
			} catch (Exception e) {
				System.out.println("oops: " + e);
			}

		} else {
			System.out.println("usuario no autorizado");
		}

	}

	public void insertarUsuario(int jerarquia) {
		if (jerarquia == 1) {
			Scanner scan = new Scanner(System.in);
			// idUsuario, login, clave, nombre, apellido, jerarquia
			System.out.print("ingrese nuevo login");
			String login = scan.next();
			System.out.print("ingrese nueva clave");
			String clave = scan.next();
			System.out.print("ingrese nombre del nuevo usuario");
			String nombre = scan.next();
			System.out.print("ingrese apellido del nuevo usuario");
			String apellido = scan.next();
			System.out.print("ingrese jerarquia del nuevo usuario (1:admin, 2:socio");
			int jerar = scan.nextInt();

			Usuario user = new Usuario(login, clave, nombre, apellido, jerar);
			try {
				String consulta = "insert into usuarios (login, clave, nombre, apellido, jerarquia)values(?,?,?,?,?)";
				usarConexion = conn.conectar();
				ps = usarConexion.prepareStatement(consulta);
				// idUsuario, login, clave, nombre, apellido, jerarquia

				// ps.setObject(1, ...); Lo comentamos porque se autogenera
				ps.setObject(1, user.getLogin());
				ps.setObject(2, user.getClave());
				ps.setObject(3, user.getNombre());
				ps.setObject(4, user.getApellido());
				ps.setObject(5, user.getJerarquia());
				ps.executeUpdate();
				System.out.println("usuario agregado exitosamente");
			} catch (Exception e) {
				System.out.println("no se puede agregar el usuario");
			}
		} else {
			System.out.println("Usuario no autorizado");
		}

	}

	public Usuario buscarUsuario(int idUsuario, int jerarquia) {
		Usuario usuario = new Usuario();
		if (jerarquia == 1) {
			try {
				usarConexion = conn.conectar(); // estamos usando la llave
				String consulta = "SELECT * FROM usuarios where idUsuario=" + idUsuario + "";// usamos esta
				stm = usarConexion.createStatement();
				rs = stm.executeQuery(consulta); // tenemos toda la inf de usuarios
				if (rs.next()) {
					Usuario user = new Usuario();
					System.out.println("paso por aqui" + rs.getString(2));
					// idUsuario, login, clave, nombre, apellido, jerarquia
					user.setIdUsuario(rs.getInt(1));
					user.setLogin(rs.getString(2));
					user.setClave(rs.getString(3));
					user.setNombre(rs.getString(4));
					user.setApellido(rs.getString(5));
					user.setJerarquia(rs.getInt(6));
					usuario = user;
				}

			} catch (Exception e) {
				System.out.println("no encontre ese usuario: " + e);
			}
		}
		return usuario;
	}

//SELECT DATEDIFF(NOW(),'2002-11-02'); #cuantos días han pasado
	// SELECT DATEDIFF(NOW(),'2010-03-20'); #Cuantos días faltan
	// date_add(now(), interval 3 day)
	public void actualizarUsuario(int jerarquia) {

		if (jerarquia == 1) {
			Scanner scan = new Scanner(System.in);
			System.out.print("Ingrese id del usuario que quiere actualizar");
			int idUsuario = scan.nextInt();
			Usuario userOldData = buscarUsuario(idUsuario, jerarquia);

			System.out.print("Cambiar login " + userOldData.getLogin() + ": ");
			String loginNew = scan.next();
			System.out.print("Nueva clave: ");
			String claveNew = scan.next();
			System.out.print("Cambiar nombre " + userOldData.getNombre() + ": ");
			String nombreNew = scan.next();
			System.out.print("Cambiar apellido " + userOldData.getApellido() + ": ");
			String apellidoNew = scan.next();
			System.out.print("Cambiar jerarquia " + userOldData.getJerarquia() + " (1:admin, 2:socio, 4:baja): ");
			int jerarquiaNew = scan.nextInt();
			String consulta = "update usuarios set login=?, clave=?, nombre=?, apellido=?, jerarquia=? where idUsuario=?";
			try {
				usarConexion = conn.conectar();
				ps = usarConexion.prepareStatement(consulta);
				// idUsuario, login, clave, nombre, apellido, jerarquia

				ps.setObject(1, loginNew);
				ps.setObject(2, claveNew);
				ps.setObject(3, nombreNew);
				ps.setObject(4, apellidoNew);
				ps.setObject(5, jerarquiaNew);
				ps.setObject(6, idUsuario);

				ps.executeUpdate();
				System.out.println("¡Datos actualizados correctamente!");
			} catch (Exception e) {
				System.out.println("oops: " + e);
			}
		} else {
			System.out.println("Usuario no autorizado");
		}

	}

	public void eliminarUsuario(int jerarquia) {
		if (jerarquia == 1) {
			try {

				Scanner scan = new Scanner(System.in);
				System.out.print("Ingrese id del usuario que quiere eliminar");
				int idUsuario = scan.nextInt();

				String consulta = "delete from usuarios where idUsuario=?";
				usarConexion = conn.conectar();
				ps = usarConexion.prepareStatement(consulta);
				ps.setInt(1, idUsuario);
				ps.executeUpdate();
				System.out.println("¡Usuario eliminado correctamente!");
			} catch (Exception e) {
				System.out.println("oops: " + e);
			}
		} else {
			System.out.println("usuario no autorizado");
		}

	}

	public Usuario validarLogin(String login, String clave) {

		Usuario userValidado = null;

		String consulta = "SELECT * FROM usuarios where login='" + login + "' and clave='" + clave + "'";
		// usamos esta consulta...
		try {
			usarConexion = conn.conectar();
			stm = usarConexion.createStatement();
			rs = stm.executeQuery(consulta); // tenemos toda la inf de usuarios

			if (rs.next()) { //pregunta si existe el registro
				Usuario usuario1 = new Usuario();
				// idUsuario, login, clave, nombre, apellido, jerarquia
				usuario1.setIdUsuario(rs.getInt(1));
				usuario1.setLogin(rs.getString(2));
				usuario1.setClave(rs.getString(3));
				usuario1.setNombre(rs.getString(4));
				usuario1.setApellido(rs.getString(5));
				usuario1.setJerarquia(rs.getInt(6));

				userValidado = usuario1;
			} else {
				System.out.println("Login o clave incorrecta");
			}

		} catch (Exception error) {
			System.out.println("oops ocurrio tal error: " + error);
		}
		return userValidado;
	}

}
