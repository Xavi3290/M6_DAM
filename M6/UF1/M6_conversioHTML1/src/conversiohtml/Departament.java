package conversiohtml;

import java.io.Serializable;


public class Departament implements Serializable
{
	private static final long serialVersionUID = 1L;
	private int	num;
	private String	nom;
	private String	poblacio;
	
	public int getNum() {
		return num;
	}
	public void setNum(int num) {
		this.num = num;
	}
	public String getNom() {
		return nom;
	}
	public void setNom(String nom) {
		this.nom = nom;
	}
	public String getPoblacio() {
		return poblacio;
	}
	public void setPoblacio(String poblacio) {
		this.poblacio = poblacio;
	}
	public static long getSerialversionuid() {
		return serialVersionUID;
	}
	public Departament() {
		super();
	}

	public Departament(int num, String nom, String poblacio) {
		super();
		this.num = num;
		this.nom = nom;
		this.poblacio = poblacio;
	}
	@Override
	public String toString() {
		return "Departament [num=" + num + ", nom=" + nom + ", poblacio=" + poblacio + "\r\n]";
	}
}