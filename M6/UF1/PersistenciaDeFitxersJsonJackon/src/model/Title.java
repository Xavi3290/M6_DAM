/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonRootName;
import com.google.gson.annotations.SerializedName;

/**
 *
 * @author xavi
 */
@JsonRootName("title")
public class Title {

    @JsonProperty("-lang")
    @SerializedName("-lang")
    String lang;
    
    @JsonProperty("#text")
    @SerializedName("#text")
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

    //@XmlAttribute    
    public void setLang(String lang) {
        this.lang = lang;
    }

    public String getTitle() {
        return title;
    }

    //@XmlValue
    public void setTitle(String title) {
        this.title = title;
    }

    @Override
    public String toString() {
        return "Title{" + "lang=" + lang + ", title=" + title + '}';
    }
}
