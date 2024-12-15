<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentResult.aspx.cs" Inherits="StudentAppASPX.StudentResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Result</title>
    <style>
        tr,td,th
        {
            border: 2px solid black ;
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Result</h2>
            <br>
            <table style="text-align: center; border: 2px solid black; border-collapse: collapse; background-color: lightcyan">
                <tr>
                    <th>Name</th>
                    <th>Mathematics</th>
                    <th>Marathi</th>
                    <th>History</th>
                </tr>
                <tr>
                    <th>Pranav</th>
                    <td>50</td>
                    <td>60</td>
                    <td>40</td>
                </tr>
                <tr>
                    <th>Kaustubh</th>
                    <td>45</td>
                    <td>70</td>
                    <td>40</td>
                </tr>
                <tr>
                    <th>Ajinkya</th>
                    <td>60</td>
                    <td>58</td>
                    <td>64</td>
                </tr>

            </table>




        </div>
    </form>
</body>
</html>
