/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

import com.google.gson.annotations.SerializedName;

/**
 *
 * @author xavi
 */
public class Bookstore_Root {
        @SerializedName("bookstore")
	private Bookstore bookstore;

	public Bookstore getBookstores() {
		return bookstore;
	}

	public void setBookstores(Bookstore bookstores) {
		this.bookstore = bookstore;
	}
}
