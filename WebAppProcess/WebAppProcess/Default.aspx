<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppProcess._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <div class="jumbotron">
        <table style="width:100%;padding:20px;height:150px">
            <tr>
                <td><label for="enter">Enter Value : </label></td>
                <td><asp:TextBox CssClass="input" ID="txtvalue" ToolTip="Input Array of values seperated by comma ,like 1,2,3" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="user" runat="server" ControlToValidate="txtvalue"   
ErrorMessage="Please enter a value" ForeColor="Red"></asp:RequiredFieldValidator>  
                </td>
                <td> ( Input Array of values seperated by comma ,like 1,2,3)</td>
            </tr>
            <tr>
                <td><asp:Button ID="btnSubmit" runat="server" CssClass="button" Text="Submit" OnClick="btnSubmit_Click" /></td>
                <td></td>
            </tr>
            <tr>
              <td > <label for="enter"><h5>List of evaluations</h5> </label>
               
           
                  </td>
                <td></td>
            </tr>
            <tr>
                <td colspan="2">
 <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </td>
            </tr>
        </table>

     
</div>

</asp:Content>
