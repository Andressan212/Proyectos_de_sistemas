package Modelo;

public class HistorialDescarga {
	private int idHistorial;
	private int idLibro;
	private int idUsuario;
	private String fecha;
	private int cantidadDia;
	private int cantidadMes;
	public HistorialDescarga(int idHistorial, int idLibro, int idUsuario, String fecha, int cantidadDia,
			int cantidadMes) {
		super();
		this.idHistorial = idHistorial;
		this.idLibro = idLibro;
		this.idUsuario = idUsuario;
		this.fecha = fecha;
		this.cantidadDia = cantidadDia;
		this.cantidadMes = cantidadMes;
	}
	
	public HistorialDescarga(int idLibro, int idUsuario, String fecha, int cantidadDia, int cantidadMes) {
		super();
		this.idLibro = idLibro;
		this.idUsuario = idUsuario;
		this.fecha = fecha;
		this.cantidadDia = cantidadDia;
		this.cantidadMes = cantidadMes;
	}
	public HistorialDescarga() {
		
	}

	public int getIdHistorial() {
		return idHistorial;
	}
	public void setIdHistorial(int idHistorial) {
		this.idHistorial = idHistorial;
	}
	public int getIdLibro() {
		return idLibro;
	}
	public void setIdLibro(int idLibro) {
		this.idLibro = idLibro;
	}
	public int getIdUsuario() {
		return idUsuario;
	}
	public void setIdUsuario(int idUsuario) {
		this.idUsuario = idUsuario;
	}
	public String getFecha() {
		return fecha;
	}
	public void setFecha(String fecha) {
		this.fecha = fecha;
	}
	public int getCantidadDia() {
		return cantidadDia;
	}
	public void setCantidadDia(int cantidadDia) {
		this.cantidadDia = cantidadDia;
	}
	public int getCantidadMes() {
		return cantidadMes;
	}
	public void setCantidadMes(int cantidadMes) {
		this.cantidadMes = cantidadMes;
	}

	

}
