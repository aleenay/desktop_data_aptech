<?xml version="1.0" encoding="utf-8"?>
<xsl:template match="/" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<html>
<head>

</head>
<body>
<table >
<tr>
<th>Name </th>
<th>Roll Number </th>

</tr>
<xsl:for-each select="collage/class">
<tr>
<td>
<xsl:value-of select="name">
</td>
<td>
<xsl:value-of select="rollnumber">
</td>
</tr>
</xsl:for-each>
</table>
</body>
</html>
</xsl:template>