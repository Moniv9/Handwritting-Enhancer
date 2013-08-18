<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
   <title>Handwritting Image Enhancer</title>
   <meta name="viewport" content="user-scalable=no,initial-scale=1.0,maximum-scale=1.0,width=device-width" />
</head>
<body>
   <div>
      <h1>
         Thanks for using Handwritting Image Enhancer</h1>
      <br />
      <br />
      <img src="<%=ViewBag.URL %>" />
   </div>
</body>
</html>
