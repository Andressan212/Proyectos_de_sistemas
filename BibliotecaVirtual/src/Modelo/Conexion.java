package Modelo;
import java.sql.Connection;
import java.sql.DriverManager;


//import java.sql.SQLException;
//import java.util.logging.Level;
//import java.util.logging.Logger;

public class Conexion {
	Connection con; 
	//private String DRIVER = "com.mysql.cj.jdbc.Driver";
	//private String BD_URL= "jdbc:mysql://localhost:3306/biblioteca";
	//private String USER = "root";
	//private String PASS = "";
	static final String JDBC_DRIVER = "com.mysql.cj.jdbc.Driver";
	static final String DB_URL = "jdbc:mysql://localhost:3306/biblioteca";
	static final String USER = "root";
	static final String PASS = "123456789";
   // Statement st=null;}
	public Connection conectar() {
		try {
			Class.forName(JDBC_DRIVER);
			//Class.forName(DRIVER); 
			System.out.println("Conecction");
			con = DriverManager.getConnection(DB_URL,USER,PASS);
			//con = DriverManager.getConnection(BD_URL,USER,PASS); 
			//st=con.createStatement()
		}catch(Exception error) { 
			System.out.println("Problemas al intentar conectar a la bd" );
		}
		return con;
	}
}
