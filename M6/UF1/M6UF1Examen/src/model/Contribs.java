/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

import jakarta.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author xavi
 */
@XmlRootElement( name = "contribs" )
public class Contribs {
    
    String contribs;

    public Contribs() {
    }

    public Contribs(String contribs) {
        this.contribs = contribs;
    }

    public String getContribs() {
        return contribs;
    }

    public void setContribs(String contribs) {
        this.contribs = contribs;
    }

    @Override
    public String toString() {
        return "Contribs{" + "contribs=" + contribs + '}';
    }
    
    
}
