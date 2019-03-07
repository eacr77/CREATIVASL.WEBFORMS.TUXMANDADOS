<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRecuperarContraseña.aspx.cs" Inherits="CREATIVASL.WEBFORMS.TUXMANDADOS.frmRecuperarContraseña" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head lang="en" class="no-js">
    <meta charset="utf-8"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimum-scale=1.0, maximum-scale=1.0"/>
		<meta name="apple-mobile-web-app-capable" content="yes"/>
		<meta name="apple-mobile-web-app-status-bar-style" content="black"/>
		<meta content="" name="description" />
		<meta content="" name="author" />
    <title>Recuperacion de contraseña</title>
        <link rel="stylesheet" href="assets/plugins/bootstrap/css/bootstrap.min.css"/>
		<link rel="stylesheet" href="assets/plugins/font-awesome/css/font-awesome.min.css"/>
		<link rel="stylesheet" href="assets/plugins/animate.css/animate.min.css"/>
		<link rel="stylesheet" href="assets/plugins/iCheck/skins/all.css"/>
		<link rel="stylesheet" href="assets/css/styles.css"/>
		<link rel="stylesheet" href="assets/css/styles-responsive.css"/>
		<link rel="stylesheet" href="assets/plugins/iCheck/skins/all.css"/>
</head>
    <body class="login">
		<div class="row">
			<div class="main-login col-xs-10 col-xs-offset-1 col-sm-8 col-sm-offset-2 col-md-4 col-md-offset-4">
				
				<!-- start: LOGIN BOX -->
				<div class="box-login">
                    <div class="logo">
					<img src="assets/images/logo.png"/>
					<h3>Recuperaci&oacute;n de contraseña</h3>					
				</div>
                    <p>
						Copie el token que recibió en su correo e ingrese su nueva contraseña
					</p>
					<form name="Elecciones" class="form-login" method="post" action="frmRecuperarContraseña.aspx" >
						<div id="errorAlertPrincipal" class="errorHandler alert alert-danger no-display">
							<i class="fa fa-remove-sign"></i> Hay errores en la captura de información. Revise los datos ingresados.
						</div>
						<div class="successHandler alert alert-success no-display">
                                <i class="fa fa-ok"></i>Cambiando contraseña espere por favor
                            </div>
                        <div class="errorHandler2 alert alert-danger no-display">
							<i class="fa fa-remove-sign"></i>El token no existe
						</div>
						<div class="successHandler2 alert alert-success no-display">
                                <i class="fa fa-ok"></i>Contraseña 
                            </div>
                        <fieldset>                            
							<div class="form-group">
								<span class="input-icon">
									<input type="text" class="form-control" name="token" placeholder="Token"/>
									<i class="fa fa-key"></i> </span>
							</div>
							<div class="form-group form-actions">
								<span class="input-icon">
									<input id="contri" type="password" class="form-control password" name="contra" placeholder="Nueva Contraseña"/>
									<i class="fa fa-lock"></i>
									 </span>
							</div>
                            <div class="form-group form-actions">
								<span class="input-icon">
									<input type="password" class="form-control password" name="confirmpassword" placeholder="Confirmar Contraseña"/>
									<i class="fa fa-lock"></i>
									 </span>
							</div>
							<div class="form-actions">								
								<button type="submit" formmethod="post" class="btn btn-green pull-right">
									Actualizar <i class="fa fa-arrow-circle-right"></i>
								</button>
							</div>
							
						</fieldset>
					</form>

					<!-- start: COPYRIGHT -->
					<div class="copyright">
						2019 &copy; CID FARES.
					</div>
					<!-- end: COPYRIGHT -->
				</div>
               
				<!-- end: LOGIN BOX -->
				<!-- start: FORGOT BOX -->
	</div>
            </div>
        <script src="assets/plugins/jQuery/jquery-2.1.1.min.js"></script>
		<!--<![endif]-->
		<script src="assets/plugins/jquery-ui/jquery-ui-1.10.2.custom.min.js"></script>
		<script src="assets/plugins/bootstrap/js/bootstrap.min.js"></script>
		<script src="assets/plugins/iCheck/jquery.icheck.min.js"></script>
		<script src="assets/plugins/jquery.transit/jquery.transit.js"></script>
		<script src="assets/plugins/TouchSwipe/jquery.touchSwipe.min.js"></script>
		<script src="assets/js/main.js"></script>
        <script src="assets/plugins/jquery-validation/dist/jquery.validate.min.js"></script>
		<script src="assets/js/login.js"></script>
        <script src="assets/js/ui-notifications.js"></script>
        <script src="assets/plugins/sweetalert/lib/sweet-alert.min.js"></script>
        <script src="assets/js/main.js"></script>
        <script src="assets/js/maps.js"></script>
        <script>
            
			jQuery(document).ready(function() {
				Main.init();
				Login.init();
			});
		</script>
</body>
</html>
