<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NumberToWordsConverter.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title></title>

    <link href="sbadmin/bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />

    <!-- MetisMenu CSS -->
    <link href="sbadmin/bower_components/metisMenu/dist/metisMenu.min.css" rel="stylesheet" />

    <!-- Timeline CSS -->
    <link href="sbadmin/dist/css/timeline.css" rel="stylesheet" />

    <!-- Custom CSS -->
    <link href="sbadmin/dist/css/sb-admin-2.css" rel="stylesheet" />

      <script type="text/javascript" src="sbadmin/bower_components/jquery/dist/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script type="text/javascript" src="sbadmin/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>

    <!-- Metis Menu Plugin JavaScript -->
    <script type="text/javascript" src="sbadmin/bower_components/metisMenu/dist/metisMenu.min.js"></script>

     <script type="text/javascript" src="sbadmin/dist/js/sb-admin-2.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="page-wrapper-hide-menu">
             <div id="divMessage" style="padding:10px 10px 10px 10px"  runat="server" visible="false"></div>
             <div class="row">
                 <div class="col-lg-12">        
                    <div class="panel panel-default">            
                        <div class="panel-heading">
                           <h3>Number to Words Converter</h3>
                        </div>
                        <div class="panel-body">
                            <div class="row">                                 
                                  <div class="col-lg-6">               
                                      <div class="form-group">
                                        <label>Input</label>
                                        <asp:TextBox ID="txtInput" runat="server" CssClass="form-control"></asp:TextBox>     
                                         <asp:RequiredFieldValidator id="rfvInput" runat="server" ControlToValidate="txtInput" ErrorMessage="Input is a required field." Display="Dynamic" ForeColor="Red" />                      
                                        <asp:RangeValidator ID="rvInput" runat="server"
                                        ControlToValidate="txtInput" ErrorMessage="Invalid input. Please enter value between 0 to 999.99" MaximumValue="999.99"
                                        MinimumValue="0" Display="Dynamic" ForeColor="Red" Type="Double"></asp:RangeValidator>
                                      </div>                                       
                                 </div> 
                                 <div class="col-lg-6">               
                                      <div class="form-group">
                                        <label>Result</label>
                                        <asp:TextBox ID="txtResult" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>     
                                                                     
                                    </div>                                       
                                 </div>  
                            </div>
                                             
                        </div>
                    </div>
        
                </div>       
                  
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <div class="form-group">
                        
                        <asp:Button ID="btnConvert"  CssClass="btn btn-primary" Width="100px" Text="Convert" OnClick="btnConvert_Click" runat="server" />
                        
                    </div> 
                </div>
            </div>
        </div>
       
    </form>
</body>
</html>
