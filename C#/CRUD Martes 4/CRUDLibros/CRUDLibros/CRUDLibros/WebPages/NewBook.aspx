<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewBook.aspx.cs" Inherits="CRUDLibros.WebPages.NewBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" type="text/css" href="../style.css" />
    <title>Nuevo Libro</title>
     <style type="text/css">
         .auto-style1 {
             width: 76px;
             height: 72px;
         }
           body{
            background-image: url(https://images.pexels.com/photos/590493/pexels-photo-590493.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940);
            background-repeat: no-repeat;
            background-size: cover;
            background-attachment: fixed;
            font-family: 'Lora', serif;
            font-size: 16px;
            color:white;
           }
        .boton{
            font-family: 'Lora', serif;
            font-size: 16px;
            background-color: #A0522D;
            border: 2px solid #A0522D;

        }
        .boton:hover {
            background-color: #DDA792;
        }
        }
        h1 {
            color:#A0522D;
        }
     </style>
</head>

<body>
    <form id="form1" runat="server">
    <div>

        <h1>Nuevo Libro</h1>
       
            <asp:Label ID="lblTitle" runat="server" Text="Título:"></asp:Label>
            <br />
            <asp:TextBox ID="txtTitle" runat="server" Width="300px" onblur="validar(1)"></asp:TextBox>
            <br />

            <asp:Label ID="LblIsbn" runat="server" Text="ISBN:"></asp:Label>
            <br />
            <asp:TextBox ID="txtIsbn" runat="server" Width="300px" onblur="validar(2)"></asp:TextBox>
            <br /> 

            <asp:Label ID="lblPublisher" runat="server" Text="Editorial:"></asp:Label>
            <br />
            <asp:TextBox ID="txtPublisher" runat="server" Width="300px" onblur="validar(3)"></asp:TextBox>
            <br />

            <asp:Label ID="lblAuthor" runat="server" Text="Autor:"></asp:Label>
             <br />
            <asp:TextBox ID="txtAuthor" runat="server" Width="300px" onblur=" validar(4)"></asp:TextBox>
            <br />
            
            <asp:Label ID="lblCategory" runat="server" Text="Género:"></asp:Label>
             <br />
            <asp:TextBox ID="txtCategory" runat="server" Width="300px" onblur="validar(5)"></asp:TextBox>

            <p />
            <asp:Button ID="btnOK" runat="server" Text="Aceptar" OnClientClick="return validar(0)" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancelar" OnClick="btnCancel_Click" />

        <script>
            function validar(campo) {

                var autor, isbn, editorial, genero, titulo, ok = true, mensaje, campo;

                titulo = document.getElementById('txtTitle').value;
                isbn = document.getElementById('txtIsbn').value;
                editorial = document.getElementById('txtPublisher').value;
                autor = document.getElementById('txtAuthor').value;
                genero = document.getElementById('txtCategory').value;

                if (campo == 0) {

                    if (titulo == '' || isNaN(isbn) || editorial == '' || autor == '' || genero == '') {                        
                        mensaje = 'Debe completar todos los campos.';
                        ok = false;
                    }
                } else {

                    switch (campo) {
                        case 1:                            
                            if (titulo == '' || autor.lenght < 3) {
                                mensaje = 'Titulo ingresado no es valido';
                                ok = false;
                            }
                            break;
                        case 2:                            
                            if (isNaN(isbn) || isbn == '') {
                                mensaje = 'ISBN no es valido';
                                ok = false;
                            }
                            break;
                        case 3:
                            
                            if (editorial == '' || autor.lenght < 3) {
                                mensaje = 'Editorial ingresada no es valida';
                                ok = false;
                            }
                            break;
                        case 4:                            
                            if (autor == '' || autor.lenght < 3) {
                                mensaje = 'Nombre de autor no es valido';
                                ok = false;
                            }
                            break;
                        case 5:                            
                            if (genero == '' || autor.lenght < 3) {
                                mensaje = 'Genero ingresado no es valido';
                                ok = false;
                            }
                            break;
                    }
                }                     

                if (ok == false) {
                    alert(mensaje);
                }
                
                return ok;
            }
        </script>


    </div>
    </form>
</body>
</html>

