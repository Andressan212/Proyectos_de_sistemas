
import java.sql.Statement;
import java.util.ArrayList;

import java.util.Scanner;

import Modelo.ConsultasHistorial;
import Modelo.ConsultasLibros;
import Modelo.ConsultasUsuarios;
import Modelo.Libro;
import Modelo.Usuario;

public class Principal {

	public static void main(String[] args) {

		Usuario usuario = null;
		Scanner scan = new Scanner(System.in);
		System.out.println("Ingresar a Biblioteca Virtual");
	    System.out.println("(1) para ingresar con cuenta \n(2) para ingresar como invitado\n");
		int ingreso = scan.nextInt();

		if (ingreso == 1) {

			System.out.print("Ingrese login\n");
			String loginIngresado = scan.next();
			System.out.print("Ingrese clave\n");
			String claveIngresada = scan.next();
			
			ConsultasUsuarios consultaUser = new ConsultasUsuarios();
			usuario = consultaUser.validarLogin(loginIngresado, claveIngresada);
			if (usuario != null) {
				ConsultasLibros consultaBook = new ConsultasLibros();
				System.out.println("Bienvenido " + usuario.getNombre() + " " + usuario.getApellido());

				if (usuario.getJerarquia() == 1) {
					System.out.println(" \n ===============Cuenta administrador===============");
					System.out.println("¿Desea agregar o modificar datos? \n 1)Si    2)No\n");

					int respuesta = scan.nextInt();
					if (respuesta == 1) {
						System.out.println("\n ===============Menu administrador===============");
						System.out.println("1) Agregar nuevo usuario");
						System.out.println("2) Modificar usuario");
						System.out.println("3) Dar baja usuario");
						System.out.println("4) Eliminar usuario");
						System.out.println("5) Mostrar socios dados de ALTA");
						System.out.println("6) Mostrar socios dados de BAJA");
						System.out.println("7) Agregar Libro nuevo");
						System.out.println("8) Modificar libro");
						System.out.println("9) Eliminar libro");
						System.out.println("0) Salir \n");

						int opcion = scan.nextInt();

						switch (opcion) {
						case 1:
							consultaUser.insertarUsuario(usuario.getJerarquia());
							
							break;
						case 2:
							consultaUser.actualizarUsuario(usuario.getJerarquia());
							break;
						case 3:
							System.out.println("no disponible aun");
							break;
						case 4:
							consultaUser.eliminarUsuario(usuario.getJerarquia());
							break;
						case 5:
							consultaUser.mostrarUsuariosSocios(usuario.getJerarquia());
							break;
						case 6:
							consultaUser.mostrarUsuariosBaja(usuario.getJerarquia());
							break;
						case 7:
							consultaBook.insertarLibro(usuario.getJerarquia());
							break;
						case 8:
							consultaBook.actualizarLibro(usuario.getJerarquia());
							break;
						case 9:
							consultaBook.eliminarLibro(usuario.getJerarquia());
							break;
						default:
							break;
						}//termina el switch

					} //termina la resp

				}//termina jerarquia 1
				
				System.out.println("\n =============CATALOGO DE LIBROS===============\n");
		
				System.out.printf("%2S,%35s,%35s,%35s,%35s%n", "ID", "TITULO", "DESCRIPCIÓN", "RUTA IMAGEN",
						"LINK DE DESCARGA");
				
				ConsultasLibros libros2 = new ConsultasLibros();
				libros2.mostrarLibros(usuario.getJerarquia());
				System.out.print("¿Desea descargar algun libro?\n 1)Si  2)No\n");
				int descarga = scan.nextInt();
				if(descarga==1) {
					Scanner scanear = new Scanner(System.in);
					System.out.print("Ingrese titulo del libro: \n");
					String libroDescarga = scanear.nextLine();
					
					ConsultasHistorial historial = new ConsultasHistorial();
					historial.descargarLibro(libroDescarga, usuario.getIdUsuario());
				}if(descarga==2){
					System.out.println("Gracias por visitarnos");
				}
			}

		}

		if (ingreso == 2) {
			System.out.println("Bienvenido usuario invitado");
			System.out.println("\n =============CATALOGO DE LIBROS===============\n");
			
			System.out.printf("%2S,%35s,%35s,%35s%n", "ID", "TITULO", "DESCRIPCIÓN", "RUTA IMAGEN");
			//TRAYENDO LOS LIBROS DE LA BASE DE DATOS
			
			ConsultasLibros libros = new ConsultasLibros();
			libros.mostrarLibros(3);
			
			
		}
	}

}
