package Modelo;

public class Usuario {

	private int idUsuario;
	private String login;
	private String clave;
	private String nombre;
	private String apellido;
	private int jerarquia;

	public Usuario(int idUsuario, String login, String clave, String nombre, String apellido, int jerarquia) {
		super();
		this.idUsuario = idUsuario;
		this.login = login;
		this.clave = clave;
		this.nombre = nombre;
		this.apellido = apellido;
		this.jerarquia = jerarquia;
	}
	

	public Usuario(String login, String clave, String nombre, String apellido, int jerarquia) {
		super();
		this.login = login;
		this.clave = clave;
		this.nombre = nombre;
		this.apellido = apellido;
		this.jerarquia = jerarquia;
	}


	public Usuario() {
	}

	public int getIdUsuario() {
		return idUsuario;
	}

	public void setIdUsuario(int idUsuario) {
		this.idUsuario = idUsuario;
	}

	public String getLogin() {
		return login;
	}

	public void setLogin(String login) {
		this.login = login;
	}

	public String getClave() {
		return clave;
	}

	public void setClave(String clave) {
		this.clave = clave;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getApellido() {
		return apellido;
	}

	public void setApellido(String apellido) {
		this.apellido = apellido;
	}

	public int getJerarquia() {
		return jerarquia;
	}

	public void setJerarquia(int jerarquia) {
		this.jerarquia = jerarquia;
	}

}
