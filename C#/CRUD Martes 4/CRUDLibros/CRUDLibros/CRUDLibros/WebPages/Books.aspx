<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="CRUDLibros.WebPages.Books" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="../style.css" />
    <title>Libros</title>
    <link href="https://fonts.googleapis.com/css?family=Lora&display=swap" rel="stylesheet"/>
    <style type="text/css">

      
        body{
            background-image: url(https://images.pexels.com/photos/590493/pexels-photo-590493.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940);
            background-repeat: no-repeat;
            background-size: cover;
            background-attachment: fixed;
            font-family: 'Lora', serif;
            font-size: 16px;
           }
        .boton{
            font-family: 'Lora', serif;
            font-size: 16px;
            background-color: #DDA792;
            color: #A0522D;
            border:2px solid #DDA792;
            height:40px;
            width:75px;
            border-radius: 5px;
        }
        .boton:hover {
            background-color:#A0522D;
            border: 2px solid #A0522D;
            color: #DDA792;
            height:45px;
            width:80px;
            border-radius: 5px;
        }
        
        .gridBookList{
            
        }
        h1 {
            color:#A0522D;
        }
        #tabla {
            text-align: center;
            margin: 0 auto;
        }
        
        table {
            opacity: 0.8;
        }
        /*E2DED6*/
        td {
            opacity:1;
        }

    </style>
</head>
<body>
    <form id="form2" runat="server">
    <div id="tabla">
            <h1>
                Libros</h1>
    
        <asp:GridView ID="gridBookList" runat="server" OnRowDataBound="gridBookList_RowDataBound" CellPadding="4" ForeColor="#A0522D" GridLines="None" HorizontalAlign="Center" AutoGenerateColumns="False">
             <AlternatingRowStyle BackColor="White" ForeColor="#A0522D" />
             <Columns>
                 <asp:BoundField DataField="BookID" HeaderText="IDLibro" />
                 <asp:BoundField DataField="Title" HeaderText="Título" />
                 <asp:BoundField DataField="Isbn" HeaderText="ISBN" />
                 <asp:BoundField DataField="PublisherName" HeaderText="Editorial" />
                 <asp:BoundField DataField="AuthorName" HeaderText="Autor" />
                 <asp:BoundField DataField="CategoryName" HeaderText="Categoría" />
             </Columns>
             <EditRowStyle BackColor="#999999" />
             <FooterStyle BackColor="#A0522D" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#A0522D" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
             <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
             <SelectedRowStyle BackColor="#E2DED6" Font-Bold="False" ForeColor="#333333" />
             <SortedAscendingCellStyle BackColor="#E9E7E2" />
             <SortedAscendingHeaderStyle BackColor="#506C8C" />
             <SortedDescendingCellStyle BackColor="#FFFDF8" />
             <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        
        <br />

        <asp:Button class="boton" ID="btnNewBook" runat="server" Text="Nuevo" OnClick="btnNewBook_Click" />
        <asp:Button class="boton" ID="btnEditBook" runat="server" Text="Editar" OnClientClick="return indexVacio()" OnClick="btnEditBook_Click" />
        <asp:Button class="boton" ID="btnDeleteBook" runat="server" Text="Eliminar" OnClientClick="return confirmar()" OnClick="btnDeleteBook_Click"/>            
                
     </div>
     </form>
        
        
    <script>

        function indexVacio() {

            ok = false;
            leer = "<%=gridBookList.SelectedIndex%>";

            if (leer != -1) {
                ok = true;
            } else {
                alert("No se selecciono ningun libro");
            }

            return ok;
        }

        function confirmar() {        
           
            /*
               La funcion lee el valor selectedIndex, que sera -1 si
               no hay ningun elemento seleccionado.
               Si algun elemento fue seleccionado, pide confirmacion para eliminar.
               Si ningun elemento fue seleccionado, informa por alert.            
            */
            var ok = false;            
            leer = "<%=gridBookList.SelectedIndex%>";
            console.log(leer);

            if (leer != -1) {
                if (confirm("Desea eliminar el libro?")) {
                    ok = true;
                }
            } else {
                alert('No se selecciono nigun libro');
            }

            return ok;
        }
    </script>
</body>
</html>

