<?xml version="1.0" encoding="utf-8"?><!-- DWXMLSource="main.xml" -->

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	
	<xsl:template match="/">
		<html>
			<body>
				<table border="2">
					<tr>
						<th>	ID		</th>
						<th>	Name	</th>
						<th>	Batch	</th>
					</tr>
                    <xsl:for-each select="Class/Students/Student">
                    	<tr>
                        	<td><xsl:value-of select="ID"/></td>
                        	<td><xsl:value-of select="Name"/></td>
                        	<td><xsl:value-of select="Batch"/></td>
                        </tr>
                    </xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
	
</xsl:stylesheet>