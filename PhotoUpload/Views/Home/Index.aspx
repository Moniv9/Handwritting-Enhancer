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
         Upload Handwritten Image to Enhance</h1>
      <form action="/home/FileUpload" method="post" enctype="multipart/form-data">
      <input type="file" name="file" title="File Upload" accept="image/*" capture><br />
      Want black & white Image
      <select name="blackwhite">
         <option>True</option>
         <option>False</option>
      </select>
      <br />
      <br />
      <input type="submit" value="Submit" />
      </form>
   </div>
</body>
</html>
