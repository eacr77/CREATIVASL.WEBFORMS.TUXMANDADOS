var FormValidator = function () {
    "use strict";  
    var validateCheckRadio = function (val) {
        $("input[type='radio'], input[type='checkbox']").on('ifChecked', function(event) {
            $(this).parent().closest(".has-error").removeClass("has-error").addClass("has-success").find(".help-block").hide().end().find('.symbol').addClass('ok');
        });
    }; 


    var runValidator = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);
        $.validator.addMethod("getEditorValue", function () {
            $("#editor1").val($('#form2 .summernote').code());
            if ($("#editor1").val() != "" && $("#editor1").val().replace(/(<([^>]+)>)/ig, "") != "") {
                $('#editor1').val('');
                return true;
            } else {
                return false;
            }
        }, 'This field is required.');
        //form2.validate({
        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else if (element.hasClass("ckeditor")) {
                    error.appendTo($(element).closest('.form-group'));
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {

                ctl00$cph_MasterBody$txtGenero: {
                    minlength: 2,
                    required: true
                },
                ctl00$cph_MasterBody$txtLetra: {
                    minlength: 1,
                    required: true
                }

            },
            messages: {
                ctl00$cph_MasterBody$txtGenero: "Por favor, ingrese el g&eacutenero.",
                ctl00$cph_MasterBody$txtLetra: "Por favor, ingrese la sigla del g&eacutenero"
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                //successHandler2.show();
                errorHandler2.hide();
                // submit form
                this.submit();
                //$('#frmMaster').trigger("submit");
            }
        });
    };

    var runValidator2 = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);
        //form2.validate({
        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else if (element.hasClass("ckeditor")) {
                    error.appendTo($(element).closest('.form-group'));
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {

                ctl00$cph_MasterBody$txtDescripcion: {
                    minlength: 2,
                    required: true
                },
                ctl00$cph_MasterBody$txtEdadInicial: {
                    minlength: 1,
                    number: true,
                    required: true
                },
                ctl00$cph_MasterBody$txtEdadFin: {
                    minlength: 1,
                    number: true,
                    required: true
                }

            },
            messages: {
                ctl00$cph_MasterBody$txtDescripcion: "Por favor, ingrese la descripci&oacuten.",
                ctl00$cph_MasterBody$txtEdadInicial: "Por favor, ingrese una edad minima",
                ctl00$cph_MasterBody$txtEdadFin: "Por favor, ingrese una edad maxima"
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                //successHandler2.show();
                errorHandler2.hide();
                // submit form
                this.submit();
                //$('#frmMaster').trigger("submit");
            }
        });
    };

    var runValidator3 = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);
        //form2.validate({
        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else if (element.hasClass("ckeditor")) {
                    error.appendTo($(element).closest('.form-group'));
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {

                //ctl00$cph_MasterBody$txtAños: {
                //    minlength: 2,
                //    required: true
                //},
                ctl00$cph_MasterBody$txtDescripcion: {
                    maxlength: 150,
                    required: true
                }
            },
            messages: {
                ctl00$cph_MasterBody$txtGraEst: "Por favor, ingrese la descripcion de grado de estudios"
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                //successHandler2.show();
                errorHandler2.hide();
                // submit form
                this.submit();
                //$('#frmMaster').trigger("submit");
            }
        });
    };

    var runValidator4 = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);
        //form2.validate({
        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else if (element.hasClass("ckeditor")) {
                    error.appendTo($(element).closest('.form-group'));
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {

                ctl00$cph_MasterBody$txtDescripcion: {
                    minlength: 2,
                    required: true
                }
            },
            messages: {
                ctl00$cph_MasterBody$txtDescripcion: "Por favor, ingrese la descripci&oacuten."
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                //successHandler2.show();
                errorHandler2.hide();
                // submit form
                this.submit();
                //$('#frmMaster').trigger("submit");
            }
        });
    };

    var runValidator5 = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);
        //form2.validate({
        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else if (element.hasClass("ckeditor")) {
                    error.appendTo($(element).closest('.form-group'));
                } else if (element.attr("name") == "ctl00$cph_MasterBody$txtColorStatus") {
                    error.insertAfter($(element).closest('.form-group').children('div'));
                }
                else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {

                ctl00$cph_MasterBody$txtDescripcion: {
                    minlength: 2,
                    required: true
                },
                ctl00$cph_MasterBody$txtColorStatus: {
                    minlength: 2,
                    required: true
                }
            },
            messages: {
                ctl00$cph_MasterBody$txtDescripcion: "Por favor, ingrese la descripci&oacuten.",
                ctl00$cph_MasterBody$txtColorStatus: "Por favor, ingrese un color de status"
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                //successHandler2.show();
                errorHandler2.hide();
                // submit form
                this.submit();
                //$('#frmMaster').trigger("submit");
            }
        });
    };

    var runValidator6 = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);
        //form2.validate({
        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else if (element.hasClass("ckeditor")) {
                    error.appendTo($(element).closest('.form-group'));
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {

                ctl00$cph_MasterBody$txtDescripcion: {
                    minlength: 2,
                    required: true
                },
                ctl00$cph_MasterBody$txtUsuario: {
                    minlength: 2,
                    required: true
                }
            },
            messages: {
                ctl00$cph_MasterBody$txtDescripcion: "Por favor, ingrese la descripci&oacuten.",
                ctl00$cph_MasterBody$txtColorStatus: "Por favor, seleccione un tipo de usuario"
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                //successHandler2.show();
                errorHandler2.hide();
                // submit form
                this.submit();
                //$('#frmMaster').trigger("submit");
            }
        });
    };

    var runValidator10 = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);
        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                }
                else if (element.attr("name") == "ctl00$cph_MasterBody$txtColor") {
                    error.insertAfter($(element).closest('.form-group').children('div'));
                } else if (element.hasClass("fileupload")) {
                    error.appendTo($(element).closest('.form-group'));
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {
                ctl00$cph_MasterBody$txtNombre: {
                    minlength: 2,
                    required: true
                },
                ctl00$cph_MasterBody$txtSigla: {
                    minlength: 1,
                    required: true
                },
                ctl00$cph_MasterBody$txtColor: {
                    minlength: 1,
                    required: true
                }
                //,
                //ctl00$cph_MasterBody$imgLogo: "TieneImagen"
            },
            messages: {
                ctl00$cph_MasterBody$txtNombre: "Por favor, ingrese el nombre del partido pol&iacute;tico.",
                ctl00$cph_MasterBody$txtSigla: "Por favor, ingrese la sigla del partido pol&iacute;tico.",
                ctl00$cph_MasterBody$txtColor: "Por favor, seleccione un color."
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                //successHandler2.show();
                errorHandler2.hide();
                // submit form
                this.submit();
                //$('#frmMaster').trigger("submit");
            }
        });
    };

    var runValidator11 = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);

        $.validator.addMethod("hfRequired", function () {
            //if ($("#cph_MasterBody$hfLatitud").val() != "" && $("#cph_MasterBody$hfLongitud").val() != "") {
            if ((document.getElementById("cph_MasterBody_hfLongitud").value == "")
                || (document.getElementById("cph_MasterBody_hfLongitud").value == undefined))
            {
                return false;
            } else {
                return true;
            }
        }, 'Seleccione un punto en el mapa.');

        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                }
                else if (element.attr("name") == "ctl00$cph_MasterBody$hfLatitud" || element.attr("name") == "ctl00$cph_MasterBody$hfLongitud") {
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else {
                    error.insertAfter(element);
                }
            },
            ignore: "",
            rules: {
                ctl00$cph_MasterBody$hfLongitud: "hfRequired",
                ctl00$cph_MasterBody$txtNombreEvento:
                {
                    minlength: 2,
                    required: true
                }
            },
            messages: {
                ctl00$cph_MasterBody$txtNombreEvento: "Por favor, ingrese el nombre del evento.",
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
                console.log("Valor: " + document.getElementById("cph_MasterBody_hfLongitud").value);
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                successHandler2.show();
                errorHandler2.hide();
                this.submit();
            }
        });
    };

    return {
        //main function to initiate template pages
        init: function (aux) {
            //runValidator();
            switch(aux)
            {
                case 1: runValidator();
                    break;
                case 2: runValidator2();
                    break;
                case 3: runValidator3();
                    break;
                case 4: runValidator4();
                    break;
                case 5: runValidator5();
                    break;
                case 6: runValidator6();
                    break;
                case 10: runValidator10();
                    break;
                case 11: runValidator11();
                    break;
            }
        }
    };
}();
