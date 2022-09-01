package Modelo;

public class Libro {
	private int idLibro;
	private String titulo;
	private String descripcion;
	private String rutaImagen;
	private String linkDescarga;

	public Libro( String titulo, String descripcion, String rutaImagen, String linkDescarga) {
		super();
		this.titulo = titulo;
		this.descripcion = descripcion;
		this.rutaImagen = rutaImagen;
		this.linkDescarga = linkDescarga;
	}
	

	public Libro(int idLibro, String titulo, String descripcion, String rutaImagen, String linkDescarga) {
		super();
		this.idLibro = idLibro;
		this.titulo = titulo;
		this.descripcion = descripcion;
		this.rutaImagen = rutaImagen;
		this.linkDescarga = linkDescarga;
	}


	public Libro() {
	}

	public int getIdLibro() {
		return idLibro;
	}

	public void setIdLibro(int idLibro) {
		this.idLibro = idLibro;
	}

	public String getTitulo() {
		return titulo;
	}

	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}

	public String getDescripcion() {
		return descripcion;
	}

	public void setDescripcion(String descripcion) {
		this.descripcion = descripcion;
	}

	public String getRutaImagen() {
		return rutaImagen;
	}

	public void setRutaImagen(String rutaImagen) {
		this.rutaImagen = rutaImagen;
	}

	public String getLinkDescarga() {
		return linkDescarga;
	}

	public void setLinkDescarga(String linkDescarga) {
		this.linkDescarga = linkDescarga;
	}

}
