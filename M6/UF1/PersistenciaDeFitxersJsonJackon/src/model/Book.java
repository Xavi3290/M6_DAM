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

@JsonRootName("book")
public class Book {
    
    @JsonProperty("-category")
    @SerializedName("-category")        
    String category;
    
    @JsonProperty("title") // no cal posarlo
    Title title;
    String author;
    int year;
    float price;

    public Book() {

    }

    public Book(String category, Title title, String author, int year, float price) {
        this.category = category;
        this.title = title;
        this.author = author;
        this.year = year;
        this.price = price;
    }

    public String getCategory() {
        return category;
    }

    //@XmlAttribute
    public void setCategory(String category) {
        this.category = category;
    }

    public Title getTitle() {
        return title;
    }

    //@XmlElement   // Si es diuen igual no fa falta posar el name, sino has de posar el name = "title"
    public void setTitle(Title title) {
        this.title = title;
    }

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    public float getPrice() {
        return price;
    }

    public void setPrice(float price) {
        this.price = price;
    }

    @Override
    public String toString() {
        return "Book{" + "category=" + category + ", title=" + title + ", author=" + author + ", year=" + year + ", price=" + price + '}';
    }
}
