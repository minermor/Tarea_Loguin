/*
 * Created by SharpDevelop.
 * User: Miny
 * Date: 17/03/2015
 * Time: 09:25 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tarea_Loguin
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			
			
			
	<?php

session_start();

        if ($_POST ['user']  !=""  AND $_POST ['pass'] !="")   {
	if ($_POST ['user'] =="MinerMor" and  $_POST [ 'pass' ]  == 

"Antony3453")  {
		$_SESSION ['admin']  = $_POST [ 'user' ] ;
      } else {
	        $_SESSION ['error'] ="Login incorrecto";
	                                                       }
      } else {
	        $_SESSION ['llene']  ="Llene los campos";
 }

header ("location:Loguear.php");

?>	


	
	
	<?php

session_start();

      if (isset ( $_SESSION ['admin'])) {
          echo "Bienvenido Usuario :  ".$_SESSION ['admin'];
    } else {
?>    

<h1> INICIAR SESION</h1>
<form action="Verificacion.php" method="post">
Usuario <br>
<input type="text" name="user"><br>

Password<br>

<input type ="password" name="pass"><br>
<input type = submit value="Iniciar sesion">

</form><br>

<?php


     if ( isset ( $_SESSION [ 'Llene' ] )) {
         echo $_SESSION ['Llene'];

unset ( $_SESSION [ 'Llene' ] );
}        elseif (isset ($_SESSION ['error'] )) {
         echo $_SESSION ['error'];

unset ( $_SESSION [ 'error' ] );
}
}

?>




	
		
	}
	}
}