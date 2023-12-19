/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package persistenciadefitxers;

import java.io.Serializable;

/**
 *
 * @author xavi
 */
public class Persona implements Serializable {
    
    String nom;
    String cognom1;
    String cognom2;
    int edat;
    String adresa; 
    static final long serialVersionUID = 1L;    //Per controlar la versio

    public Persona(String nom, String cognom1, String cognom2, int edat, String adresa) {
        this.nom = nom;
        this.cognom1 = cognom1;
        this.cognom2 = cognom2;
        this.edat = edat;
        this.adresa = adresa;
    }   

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getCognom1() {
        return cognom1;
    }

    public void setCognom1(String cognom1) {
        this.cognom1 = cognom1;
    }

    public String getCognom2() {
        return cognom2;
    }

    public void setCognom2(String cognom2) {
        this.cognom2 = cognom2;
    }

    public int getEdat() {
        return edat;
    }

    public void setEdat(int edat) {
        this.edat = edat;
    }

    public String getAdresa() {
        return adresa;
    }

    public void setAdresa(String adresa) {
        this.adresa = adresa;
    }

    @Override
    public String toString() {
        return "Persona{" + "nom=" + nom + ", cognom1=" + cognom1 + ", cognom2=" + cognom2 + ", edat=" + edat + ", adresa=" + adresa + '}';
    }   
    
    
    
    
}
