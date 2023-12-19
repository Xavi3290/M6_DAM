/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

import jakarta.xml.bind.annotation.XmlAttribute;
import jakarta.xml.bind.annotation.XmlRootElement;
import jakarta.xml.bind.annotation.XmlValue;

/**
 *
 * @author xavi
 */
@XmlRootElement( name = "title" )
public class Title {
    
    String lang;
    String title;

    public Title() {
    }

    public Title(String lang, String title) {
        this.lang = lang;
        this.title = title;
    }

    public String getLang() {
        return lang;
    }

    @XmlAttribute
    public void setLang(String lang) {
        this.lang = lang;
    }

    public String getTitle() {
        return title;
    }

    @XmlValue
    public void setTitle(String title) {
        this.title = title;
    }
        

    @Override
    public String toString() {
        return "Title{" + "lang=" + lang + ", title=" + title + '}';
    }
    
}
