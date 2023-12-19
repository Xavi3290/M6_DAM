/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonRootName;
import com.google.gson.annotations.SerializedName;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author xavi
 */
@JsonRootName("bookstore")
public class Bookstore {

    //@XmlElement(name = "book")
    @SerializedName("book")
    private List<Book> bookstore;

    public List<Book> getBookstore() {
        return bookstore;
    }

    @JsonProperty("book")
    public void setBookstore(List<Book> bookstore) {
        this.bookstore = bookstore;
    }

    public void add(Book book) {
        if (this.bookstore == null) {
            this.bookstore = new ArrayList<Book>();
        }
        this.bookstore.add(book);
    }

    @Override
    public String toString() {
        String s = "";
        for (Book bo : bookstore) {
            s = s + bo.toString() + "\n";
        }
        return s;
    }
    
}
