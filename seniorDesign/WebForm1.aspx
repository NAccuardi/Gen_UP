<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="seniorDesign.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div style="width: 100%">
            <div style="width: 60%">
                <table>
                    <tr>                      
                        <asp:Label ID="Lbl_UserName" runat="server" Text="Label"></asp:Label>
                    </tr>   
                    <tr>
                        <asp:GridView ID="GridView_Data" runat="server">
                        </asp:GridView>
                    </tr>

                </table>
                
                
                
                
                
            </div>
        </div>
        
    </form>
</body>
</html>
