<%@ Page Language="C#" AutoEventWireup="true" CodeFile="People.aspx.cs" Inherits="People" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">



   

        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand"  href="~/">Application name</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a  href="~/">Home</a></li>
                        <li><a  href="~/People">People Table</a></li>
                        
                    </ul>
                   
                </div>
            </div>
        </nav>
             
<body>
    <form id="form1" runat="server">  
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:Button ID="Button1" runat="server" OnClick="DeletePerson" Text="Delete" />
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
                       <asp:Label runat="server" Text="Name:" ID="NameLabel0"></asp:Label>  
                       <asp:TextBox ID="NameBox0" runat="server"></asp:TextBox>  
                        <asp:Label runat="server" Text="Age:" ID="Label1"></asp:Label>  
                        <asp:TextBox ID="AgeBox0" runat="server"></asp:TextBox>  
                        <asp:Button ID="CreateButton0" runat="server" Text="Update" AutoPostBack="True" OnClick="UpdatePerson" style="width: 61px" />
        <div>  
            <table class="auto-style1">  
                <tr>  
                    <td class="auto-style2">  
                       <asp:Label runat="server" Text="Name:" ID="NameLabel"></asp:Label></td>  
                    <td>  
                       <asp:TextBox ID="NameBox" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td class="auto-style2">  
                        <asp:Label runat="server" Text="Age:"></asp:Label></td>  
                    <td>  
                        <asp:TextBox ID="AgeBox" runat="server"></asp:TextBox></td>  
                </tr>  
               
                <tr>  
                    <td class="auto-style2"></td>  
                    <td>  
                        <asp:Button ID="CreateButton" runat="server" Text="Submit" AutoPostBack="True" OnClick="CreatePerson" /></td>  
                </tr>  
            </table>  
        </div>  
        <div>
  <asp:GridView ID="GridView1" runat="server" AutoPostBack="True"></asp:GridView>
            </div>
    
    </form>  

    
   
    
</body>
</html>
