<?xml version="1.0" encoding='ISO-8859-1'?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match='/'>
		<html>
			<head><title>LLISTAT DE DEPARTAMENTS</title></head>
			<body> 
				<h1>Llistat de Departaments</h1>
				<table border='1'>
					<tr>
						<td><b>N&#xfa;mero</b></td>
						<td><b>Nom</b></td>
						<td><b>Poblaci&#xf3;</b></td>
					</tr>
					<xsl:apply-templates />
				</table>
			</body>
		</html>
	</xsl:template>

	<xsl:template match='departament'>
		<tr>
			<xsl:apply-templates />
		</tr>
	</xsl:template>
	
	<xsl:template match='num|nom|poblacio'>
		<td>
			<xsl:apply-templates />
		</td>
	</xsl:template>
	
</xsl:stylesheet>
