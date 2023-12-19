/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.testwhilebo;

/**
 *
 * @author xavi
 */
public class Assignatura {
    
    String nom;
    boolean disponible;

    public Assignatura() {
    }

    public Assignatura(String nom, boolean disponible) {
        this.nom = nom;
        this.disponible = disponible;
    }    

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public boolean isDisponible() {
        return disponible;
    }

    public void setDisponible(boolean disponible) {
        this.disponible = disponible;
    }
    
}
