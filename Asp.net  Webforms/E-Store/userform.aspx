<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userform.aspx.cs" Inherits="E_Store.userform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="Usersid" HeaderText="Usersid" InsertVisible="False" ReadOnly="True" SortExpression="Usersid" />
                    <asp:BoundField DataField="Usersname" HeaderText="Usersname" SortExpression="Usersname" />
                    <asp:BoundField DataField="UsersAddress" HeaderText="UsersAddress" SortExpression="UsersAddress" />
                    <asp:BoundField DataField="UserPhoneNo" HeaderText="UserPhoneNo" SortExpression="UserPhoneNo" />
                    <asp:BoundField DataField="UserEmail" HeaderText="UserEmail" SortExpression="UserEmail" />
                    <asp:BoundField DataField="UserPass" HeaderText="UserPass" SortExpression="UserPass" />
                    <asp:BoundField DataField="CreatedON" HeaderText="CreatedON" SortExpression="CreatedON" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sqlConnection %>" SelectCommand="SELECT * FROM [users]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <asp:Repeater ID="Repeater2" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="Repeater2_ItemCommand">
                <ItemTemplate>
                    <table border="1" width="250" height="250">
                        <tr>
                            <td>
                                <h2>ID</h2>
                            </td>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("Usersid") %>'></asp:Label>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <h2>  UserName  </h2>
                            </td>
                            <td>
                                 <asp:Label ID="Label2" runat="server" Text='<%#Eval("Usersname") %>'></asp:Label>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <SeparatorTemplate>
                    <br />
                </SeparatorTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
