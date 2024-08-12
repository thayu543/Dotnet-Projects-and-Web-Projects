<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProductWebSite.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
 </div>
               product code:
<asp:textbox id="txt_product_code" runat="server"></asp:textbox><br/><br/>
        product name:
<asp:textbox id="txt_product_name" runat="server"></asp:textbox><br/><br/>
          quantity:
<asp:textbox id="txt_quantity" runat="server"></asp:textbox><br/><br/>
        rate:
<asp:textbox id="txt_rate" runat="server"></asp:textbox><br/><br/>
        percentage:
<asp:textbox id="txt_percentage" runat="server"></asp:textbox><br/><br/>
  
<asp:button id="btninsert" runat="server" text="insert" onclick="insert"/>
<hr/>
    </form>
</body>
</html>
