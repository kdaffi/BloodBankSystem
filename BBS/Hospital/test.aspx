﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Hospital/HospitalMaster.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="BBS.Hospital.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<body>
    <h1>Test page for Table Filter</h1>
    <table>
      <thead>
        <tr>
          <th>Lorem Ipsum</th>
          <th>Dolor Sit Amet</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>Ut egestas consectetur elit</td>
          <td>sit amet sollicitudin ligula euismod at</td>
        </tr>
        <tr>
          <td>Integer non purus libero</td>
          <td>nec pellentesque lorem</td>
        </tr>
        <tr>
          <td>Sed posuere est ac arcu</td>
          <td>feugiat placerat</td>
        </tr>
        <tr>
          <td>Vivamus lobortis nisi sit</td>
          <td>amet purus sollicitudin congue</td>
        </tr>
        <tr>
          <td>Suspendisse euismod lectus</td>
          <td>nec neque viverra vulputate</td>
        </tr>
        <tr>
          <td>Duis sed velit ante</td>
          <td>in pellentesque erat</td>
        </tr>
        <tr>
          <td>Vestibulum eu diam sed ipsum</td>
          <td>luctus sollicitudin at sit amet lorem</td>
        </tr>
        <tr>
          <td>Cras rutrum sem non quam porttitor</td>
          <td>eu consectetur tortor tristique</td>
        </tr>
        <tr>
          <td>Cras dapibus interdum turpis</td>
          <td>convallis tincidunt elit lobortis sed</td>
        </tr>
        <tr>
          <td>Nam consectetur eros vitae dui</td>
          <td>rutrum ac porttitor felis pharetra</td>
        </tr>
        <tr>
          <td>Pellentesque ut velit libero</td>
          <td>quis sodales ligula</td>
        </tr>
        <tr>
          <td>Integer at enim non</td>
          <td>enim vestibulum sodales</td>
        </tr>
        <tr>
          <td>Curabitur sagittis libero</td>
          <td>ultricies mi interdum dictum</td>
        </tr>
        <tr>
          <td>Donec pretium tincidunt libero</td>
          <td>a rutrum dui venenatis ac</td>
        </tr>
        <tr>
          <td>Vivamus ut nunc dolor</td>
          <td>vitae volutpat urna</td>
        </tr>
        <tr>
          <td>Morbi malesuada sagittis dolor</td>
          <td>nec porta nisi convallis at</td>
        </tr>
        <tr>
          <td>Nullam luctus pretium mauris</td>
          <td>quis adipiscing nibh convallis vitae</td>
        </tr>
        <tr>
          <td>Maecenas vel felis tortor</td>
          <td>nec pulvinar dolor</td>
        </tr>
        <tr>
          <td>Nunc ut arcu vitae ligula</td>
          <td>ullamcorper malesuada id vitae ligula</td>
        </tr>
        <tr>
          <td>Vivamus condimentum laoreet est</td>
          <td>sed luctus tortor laoreet non</td>
        </tr>
        <tr>
          <td>Aliquam eget arcu turpis</td>
          <td>pretium faucibus ante</td>
        </tr>
        <tr>
          <td>Vestibulum quis nisi quis</td>
          <td>enim tincidunt vulputate</td>
        </tr>
        <tr>
          <td>In a odio iaculis</td>
          <td>justo sollicitudin porttitor</td>
        </tr>
        <tr>
          <td>Aliquam id felis eu tortor</td>
          <td>ornare vehicula</td>
        </tr>
        <tr>
          <td>Praesent consequat dui at justo</td>
          <td>gravida ac mollis elit placerat</td>
        </tr>
      </tbody>
    </table>

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.min.js"></script>
    <script src="../Scripts/jquery.simple-table-filter.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("table").addTableFilter();
        });
    </script>
  </body>
</asp:Content>
