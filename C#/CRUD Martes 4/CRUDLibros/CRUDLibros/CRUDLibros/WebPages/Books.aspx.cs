﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Configuration;
using CRUDLibros.Data;

namespace CRUDLibros.WebPages
{

    public partial class Books : System.Web.UI.Page
    {

        private string connectionString = WebConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillBookGrid();
            }
        }

        private void FillBookGrid()
        {

            List<Book> bookList = new List<Book>();

            Book book = new Book();

            bookList = book.GetBooks(connectionString);

            gridBookList.DataSource = bookList;

            gridBookList.DataBind();
        }

        protected void btnNewBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewBook.aspx");
        }

        protected void btnEditBook_Click(object sender, EventArgs e)
        {
            string bookId = null;

            if (gridBookList.SelectedIndex != -1)
                bookId = gridBookList.SelectedRow.Cells[0].Text;

            Response.Redirect("EditBook.aspx?bookid=" + bookId);

        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow row in gridBookList.Rows)
            {
                row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference
                    (gridBookList, "Select$" + row.RowIndex.ToString(), true));
            }

            base.Render(writer);
        }

        protected void gridBookList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("OnMouseOver", "this.style.cursor='pointer';");
                e.Row.ToolTip = "Click en la fila para seleccionarla";
            }
        }

        protected void btnDeleteBook_Click(object sender, EventArgs e)
        {
          
            int bookId = 0;           
           
                if (gridBookList.SelectedIndex != -1)
                {
                    ///Additional information: El índice estaba fuera del intervalo. 
                    ///Debe ser un valor no negativo e inferior al tamaño de la colección.
                    ///
                    bookId = Convert.ToInt32(gridBookList.SelectedRow.Cells[0].Text);

                    Book libro = new Book();

                    libro.DeleteBook(connectionString, bookId);

                    FillBookGrid();

                    gridBookList.SelectedIndex = -1;


                }           

        }
       



    }
}