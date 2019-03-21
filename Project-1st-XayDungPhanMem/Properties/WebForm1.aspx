<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Project_1st_XayDungPhanMem.Properties.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Project đầu tiên</title>
    <link href='C:\Users\Toan Nguyen\source\repos\Project-1st-XayDungPhanMem\Project-1st-XayDungPhanMem\CSS.css' type="text/css" rel="stylesheet" />


</head>
<body style="height: 540px">
    <form id="form1" runat="server">
   

            <div id="select-items-function">
                <p style="height: 38px">Chức năng chọn items ở đây 
               
                </p>
                <div>
                    <div style="width: 862px" class="box-products">
                        <div>
                            <div>
                                <asp:DropDownList ID="DropDownList_Type_of_Product" runat="server" OnSelectedIndexChanged="DropDownList_Type_of_Product_TextChanged" OnTextChanged="DropDownList_Type_of_Product_TextChanged">
                                    <asp:ListItem Value="all">Tất cả</asp:ListItem>
                                    <asp:ListItem  Value="main">Bo mạch chủ</asp:ListItem>
                                    <asp:ListItem  Value="chip">Vi xử lý</asp:ListItem>
                                    <asp:ListItem  Value="ram">Bộ nhớ trong</asp:ListItem>
                                    <asp:ListItem Value="ssd">Ổ cứng(SSD)</asp:ListItem>
                                    <asp:ListItem  Value="hdd">Ổ cứng(HDD)</asp:ListItem>
                                    <asp:ListItem  Value="monitor">Màn hình</asp:ListItem>
                                    <asp:ListItem Value="case">Vỏ thùng PC</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tìm kiếm" />

                            </div>
                                 <asp:GridView ID="GridView1" runat="server" style="margin-top: 69px" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                     <AlternatingRowStyle BackColor="White" />
                                     <EditRowStyle BackColor="#2461BF" />
                                     <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                     <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                     <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                     <RowStyle BackColor="#EFF3FB" />
                                     <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                     <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                     <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                     <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                     <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                     <Columns>
                                    <asp:CommandField ShowSelectButton="True" />
                                   
                                </Columns>
                           
                                 </asp:GridView>
                            <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" OnRowDeleting="Gridview2_RowDeleting" Width="369px" >
                                <AlternatingRowStyle BackColor="White" />
                           
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" />
                                   <asp:CommandField ShowDeleteButton="true" />
                                </Columns>
                           
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            </asp:GridView>

                        </div>
                        <div style="float:right">
                            <div>
                                <asp:Label ID="Label2" runat="server" Text="ID Hoa Don"></asp:Label>
                                <asp:TextBox ID="txtIDHD" runat="server"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="Label3" runat="server" Text="ID Nhan Vien"></asp:Label>
                                <asp:TextBox ID="txtIDNV" runat="server"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="Label1" runat="server" Text="CMND Khach hang"></asp:Label>
                                <asp:TextBox ID="txtCMND" runat="server"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="Label4" runat="server" Text="Trang Thai"></asp:Label>
                                <asp:TextBox ID="txtTrangThai" runat="server"></asp:TextBox>
                            </div>
                            <div>
                                
                                <asp:Label ID="Label5" runat="server" Text="Ngay Lap HD"></asp:Label>
                                <asp:TextBox ID="txtNgayLapHD" runat="server"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="Label6" runat="server" Text="ID Phiếu giao"></asp:Label>
                                <asp:TextBox ID="txtIDPG" runat="server"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="Label7" runat="server" Text="Ngày Giao"></asp:Label>
                                <asp:TextBox ID="txtngaygiao" runat="server"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="Label8" runat="server" Text="Dịa chỉ giao"></asp:Label>
                                <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
                            </div>
                            <div><asp:Button ID="btnHoadon" runat="server" OnClick="insert_bill" Text="Lập hóa đơn và phiếu giao" /></div>
                        </div>
                    </div>

                    <div style="width: 189px" class="box-selected-products">
                    </div>

                </div>

            </div>
        
        <div style="height: 74px">
        <asp:Label ID="Label_SumAll" runat="server" Text="Tổng tiền tạm tính :"></asp:Label>
        <asp:TextBox ID="TextBox_SumAll" runat="server" Enabled="False"></asp:TextBox>
            <asp:Label ID="Label_Discount" runat="server" Text="Mã giảm giá (combo)"></asp:Label>
            <asp:TextBox ID="TextBox_Discount" runat="server"></asp:TextBox>
            <asp:Button ID="Button_Discount" runat="server" OnClick="Button_Discount_Click" Text="Tính giá tiền cuối" />
            <asp:Label ID="Label_last_Money" runat="server" Text="Tổng tiên cuối cùng"></asp:Label>
            <asp:TextBox ID="TextBox_last_Money" runat="server"></asp:TextBox>
            </div>
    </form>
</body>
</html>

