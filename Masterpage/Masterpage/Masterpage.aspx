<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Masterpage.aspx.vb" Inherits="Masterpage.Masterpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style=""font-family: Arial">
            <tr>
                <td colspan="2" style="width: 800px; height: 80px; background-color: #BDBDBD; text-align: center">
                    <h1>
                        Website Header
                    </h1>

                </td>
            </tr>


            <tr>
                <td style="width: 150px; height: 500px; background-color: #D8D8D8;">
                    <h3>
                        Menu
                    </h3>

                </td>
                <td style="width: 650px; height: 500px; background-color: #E6E6E6;">
                    <h2>
                        This section changes on page by page basis
                    </h2>
                 </td>

            </tr>


             <tr>
                <td colspan="2" style="background-color: #BDBDBD; text-align: center">
                    <h1>
                        Website Footer
                    </h1>

                </td>
            </tr>
            
        </table>
    
        <br />
        <br />
        <br />
     
    
    </div>
    </form>
</body>
</html>
