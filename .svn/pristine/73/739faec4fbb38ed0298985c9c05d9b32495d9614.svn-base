$.fn.bxhValidateForm = function (parameters) {
    var defaults = {
        addHighLightError: (parameters == null || parameters.addHighLightError == null) ? null : parameters.addHighLightError,
        cleanError: (parameters == null || parameters.cleanError == null) ? function (obj) {
            $(obj).removeClass('bxhvalierror');
            if ($('#' + $(obj).attr('id') + '_validate').length > 0) $('#' + $(obj).attr('id') + '_validate').remove();
        } : parameters.cleanError,
        showError: (parameters == null || parameters.showError == null) ? function (obj, validateMessage) {
            $(obj).addClass('bxhvalierror');
            //var tooltiptop = $(obj).position().top;
            //var tooltipleft = $(obj).position().left + $(obj).width() + 20;
            //var marginleft = $(obj).position().left;
            if (parameters == null || parameters.addHighLightError == null || parameters.addHighLightError == false)
            {
                $(obj).after('<div id="' + $(obj).attr('id') + '_validate" class="bxhvalidatetooltip">' + validateMessage + '</div>');
            } 
        } : parameters.showError, 
        showErrorInCombo: (parameters == null || parameters.showErrorInCombo == null) ? function (obj, validateMessage) {
            $(obj).after('<div id="' + $(obj).attr('id') + '_validate" class="bxhvalidatetooltip">' + validateMessage + '</div>');
        } : parameters.showErrorInCombo,
        funcOnClick: (parameters == null || parameters.funcOnClick == null) ? null : parameters.funcOnClick
    };
    var lsObjIDError = ''; //chứa id các đối tượng bị lỗi    
    var errorTopPosition = 999999; //vị trí Obj cao nhất bị lỗi 
    var BXHIsNumericAndDot = function(sText) {
        var validChars = "0123456789.";
        var isNumber = true;
        var onechar;
        for (var i = 0; i < sText.length && isNumber == true; i++) {
            onechar = sText.charAt(i);
            if (validChars.indexOf(onechar) == -1) {
                isNumber = false;
            }
        }
        return isNumber;
    };

    var BXHIsNumeric = function(sText) {
        var validChars = "0123456789.";
        var isNumber = true;
        var onechar;
        for (var i = 0; i < sText.length && isNumber == true; i++) {
            onechar = sText.charAt(i);
            if (validChars.indexOf(onechar) == -1) {
                isNumber = false;
            }
        }
        return isNumber;
    };

    var IsContainHTMLTag = function(input)
    {
        return /<[a-z][\s\S]*>/i.test(input);
    }
    
    this.each(function () {
        var objInstantID = $(this).attr('id');
        var _this = this;
        $('#' + objInstantID + ' .bxhInputValidate').blur(function () {
            if ($(this).hasClass('bxhInputValidateRequired')) {
                defaults.cleanError(this);//xóa validate lỗi
                var validateMessage = 'Vui lòng nhập ' + $(this).attr('ValidateMessage');//lấy thông tin cần hiện
                if ($(this).val().trim() == '') {
                    defaults.showError($(this), validateMessage);
                    lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                    if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                    return;
                }
            }
            if ($(this).hasClass("bxhEmailValidate")) {
                defaults.cleanError(this);//xóa validate lỗi
                var validateMessage = 'Vui lòng nhập ' + $(this).attr('ValidateMessage') + ' đúng định dạng';//lấy thông tin cần hiện
                var re = /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i;
                if (!re.test($(this).val().trim()) && $(this).val().trim() != '') {
                    defaults.showError($(this), validateMessage);
                    lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                    if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                    return;
                }
            }
            //0. Phải bắt đầu là 0
            //1. Nếu là số 1 thì bắt buộc 11 số
            //2. Nếu là số 9 thì là 10 số
            //3. Nếu là số 8 thì hoặc là 10 hoặc là 8
            //4. Còn lại là số bàn, 8 số thôi --> vô lý
            if ($(this).hasClass('bxhInputValidatePhoneNumber')) {
                defaults.cleanError(this);//xóa validate lỗi
                var validateMessage = 'Vui lòng nhập ' + $(this).attr('ValidateMessage') + ' phải là 8-11 số';//lấy thông tin cần hiện
                if (($(this).val() != '' && ($(this).val().length < 8 || $(this).val().length > 11)) //nếu khác rỗng và số nhập ngoài khoản 8-11 số
                    || $(this).val() != '' && !BXHIsNumericAndDot($(this).val())) //nếu khác rỗng và lại không gồm số và .
                {
                    defaults.showError($(this), validateMessage);
                    lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                    if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                    return;
                }
                else if ($(this).val() != '')
                {
                    var phone = $(this).val();
                    if (phone[0] != 0
                        || (phone[1] == 1 && $(this).val().length != 11)
                        || (phone[1] == 9 && $(this).val().length != 10)
                        || (phone[1] == 8 && ($(this).val().length != 10 && $(this).val().length != 8))
                        )
                    {
                        defaults.showError($(this), "Không phải số điện thoại");
                        lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                        if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                        return;
                    }
                    else {

                    }
                }
            }
            if ($(this).hasClass('bxhInputValidateIsNumberAndDot')) {
                defaults.cleanError(this);//xóa validate lỗi
                var validateMessage = 'Vui lòng nhập ' + $(this).attr('ValidateMessage') + ' phải là số';//lấy thông tin cần hiện
                if (!BXHIsNumericAndDot($(this).val())) //nếu có lỗi
                {
                    defaults.showError($(this), validateMessage);
                    lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                    if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                    return;
                }
            }
            if ($(this).hasClass('bxhInputValidateIsNumber')) {
                defaults.cleanError(this);//xóa validate lỗi
                var validateMessage = 'Vui lòng nhập ' + $(this).attr('ValidateMessage') + ' phải là số';//lấy thông tin cần hiện
                if (!BXHIsNumeric($(this).val())) //nếu có lỗi
                {
                    defaults.showError($(this), validateMessage);
                    lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                    if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                    return;
                }
            }
            if ($(this).hasClass('bxhInputValidateIsNumberRatherZero')) {
                defaults.cleanError(this);//xóa validate lỗi
                var validateMessage = 'Vui lòng nhập ' + $(this).attr('ValidateMessage') + ' phải là số lớn hơn 0';//lấy thông tin cần hiện
                if (!BXHIsNumeric($(this).val()) || eval($(this).val()) == 0) //nếu có lỗi
                {
                    defaults.showError($(this), validateMessage);
                    lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                    if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                    return;
                }
            }
            if ($(this).hasClass('bxhInputValidateFullName')) {
                defaults.cleanError(this);//xóa validate lỗi                
                if ($(this).val().trim() != '') {
                    if (!contains($(this).val())) {
                        validateMessage = $(this).attr('ValidateMessage') + ' không hợp lệ';
                        defaults.showError($(this), validateMessage);
                        lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                        if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                        return;
                    }
                }
            }
            if ($(this).hasClass('bxhInputValidateFullNameSalon')) {                
                defaults.cleanError(this);//xóa validate lỗi                
                if ($(this).val().trim() != '') {
                    var salonName = $(this).attr('salonname');                    
                    if(!contains($(this).val().trim()) && $(this).val().trim().toLowerCase() != salonName.trim().toLowerCase()) {
                        validateMessage = 'Tên liên hệ không hợp lệ';
                        defaults.showError($(this), validateMessage);
                        lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                        if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                        return;
                    }
                }
            }
            if ($(this).hasClass('bxhInputValidateSpecial')) {
                defaults.cleanError(this);//xóa validate lỗi                
                if ($(this).val().trim() != '') {                    
                    if (!contains($(this).val().trim())) {
                        validateMessage = $(this).attr('ValidateMessage') + ' không hợp lệ';
                        defaults.showError($(this), validateMessage);
                        lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                        //alert(lsObjIDError);
                        if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                        return;
                    }
                }
            }
            if ($(this).hasClass('bxhInputValidateMaxLength')) {
                defaults.cleanError(this);//xóa validate lỗi
                var validateMessage = "";//lấy thông tin cần hiện                               

                if ($(this).val().trim() == '') {
                    validateMessage = 'Vui lòng nhập ' + $(this).attr('ValidateMessage');
                    defaults.showError($(this), validateMessage);
                    lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                    if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                    return;
                }
                if ($(this).val().trim() != '' && $(this).val().trim().length < 100) {
                    validateMessage = 'Vui lòng nhập ' + $(this).attr('ValidateMessage') + ' lớn hơn 100 ký tự';
                    defaults.showError($(this), validateMessage);
                    lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                    if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                    return;
                }
                if ($(this).val().trim() != '' && $(this).val().trim().length > 3000) {
                    validateMessage = 'Vui lòng nhập ' + $(this).attr('ValidateMessage') + ' nhỏ hơn 3000';
                    defaults.showError($(this), validateMessage);
                    lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                    if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                    return;
                }              
            }

            if ($(this).hasClass('bxhInputValidateCheckUserName')) {
                var _this = $(this);
                defaults.cleanError(this);//xóa validate lỗi
                var validateMessage = "";                
                if ($(this).val() != '') {                                                     
                    if ($(this).val().indexOf('admin') != -1 || $(this).val().indexOf('banxehoi') != -1 ) {
                        validateMessage = $(this).attr('ValidateMessage') + ' không hợp lệ';
                        defaults.showError($(this), validateMessage);
                        lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                        if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                        return;
                    }
                    //Hàm check user đã tồn tại
                    $.ajaxSetup({
                        async: false
                    });
                    $.ajax({
                        type: "GET",
                        cache: false,
                        url: "/member/account/check/" + encodeURI($(this).val()),
                        async: false,
                        success: function (data) {
                            if (data == true) {
                                validateMessage = $(_this).attr('ValidateMessage') + ' này đã được đăng ký';
                                defaults.showError($(_this), validateMessage);
                                lsObjIDError += $(_this).attr('id') + ','; //thêm vào list các id bị lỗi
                                if ($(_this).offset().top < errorTopPosition) errorTopPosition = $(_this).offset().top;
                                return;
                            }
                        }
                    });                    
                }         
            }

            if ($(this).hasClass('bxhInputValidatePassword')) {
                defaults.cleanError(this);//xóa validate lỗi
                var validateMessage = 'Vui lòng nhập ' + $(this).attr('ValidateMessage') + ' từ 6 ký tự trở lên';//lấy thông tin cần hiện
                if ($(this).val().length < 6) {
                    defaults.showError($(this), validateMessage);
                    lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                    if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                    return;
                };
            };

            if ($(this).hasClass('bxhInputValidateRepeatPassword')) {
                defaults.cleanError(this);//xóa validate lỗi
                var validateMessage = $(this).attr('ValidateMessage') + ' gõ lại không khớp';//lấy thông tin cần hiện
                if ($(this).val() != $('.bxhInputValidatePassword').val()) {
                    defaults.showError($(this), validateMessage);
                    lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                    if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                    return;                    
                };
            };

            if ($(this).hasClass('bxhInputValidateMultiple')) { // Check là bội số của 10000
                defaults.cleanError(this);//xóa validate lỗi                
                if ($(this).val().trim() != '') {
                    var value = $(this).val().trim().replace(/\./g, '');
                    if ( (eval(value)%10000) != 0) {
                        validateMessage = $(this).attr('ValidateMessage') + ' không hợp lệ';
                        defaults.showError($(this), validateMessage);
                        lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                        //alert(lsObjIDError);
                        if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                        return;
                    }
                }
            };

            if ($(this).hasClass('bxhInputValidateNotContainHTMLTag')) { // Check là bội số của 10000
                defaults.cleanError(this);//xóa validate lỗi                
                if ($(this).val().trim() != '') {
                    var value = $(this).val().trim()
                    if (IsContainHTMLTag(value)) {
                        validateMessage = $(this).attr('ValidateMessage') + ' chứa mã HTML';
                        defaults.showError($(this), validateMessage);
                        lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                        //alert(lsObjIDError);
                        if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                        return;
                    }
                }
            };
        });

        // Select thường
        var BXHSelectOption = function () {
            $('#' + objInstantID + ' .bxhSelectOptionValidate').each(function () {
                if ($(this).hasClass('bxhSelectOptionValidateRequired')) {
                    defaults.cleanError(this); //xóa validate lỗi
                    var validateMessage = 'Vui lòng chọn ' + $(this).attr('ValidateMessage'); //lấy thông tin cần hiện
                    if ($(this).val() <= 0) {
                        defaults.showErrorInCombo($(this), validateMessage);
                        lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                        if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                        return;
                    }
                }
            });
        };
        var BXHComboValidate = function() {
            $('#' + objInstantID + ' .bxhSelectValidate').each(function() {
                if ($(this).hasClass('bxhSelectValidateRequired')) {
                    defaults.cleanError(this); //xóa validate lỗi
                    //khong hieu targetObj là gì? vinhph --> là đối tượng model lấy value để đưa post lên (<input type="hidden" id="userID" ..., <input type="hidden" id="userID" ...)
                    if ($(this).find('.targetObj').val().trim() == '' || eval($(this).find('.targetObj').val()) == 0) {
                        var validateMessage = 'Vui lòng chọn ' + $(this).attr('ValidateMessage'); //lấy thông tin cần hiện
                        defaults.showErrorInCombo($(this), validateMessage);
                        lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                        if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                        return;
                    }
                    return;
                }
            });
        };
        var BXHAutoCompleteCityComboValidate = function () {
            $('#' + objInstantID + ' .bxhAutoCompleteCityCombo').each(function () {
                if ($(this).hasClass('bxhAutoCompleteCityComboRequired')) {
                    defaults.cleanError(this); //xóa validate lỗi
                    //khong hieu targetObj là gì? vinhph --> là đối tượng model lấy value để đưa post lên (<input type="hidden" id="userID" ..., <input type="hidden" id="userID" ...)
                    if ($(this).find('.targetObj').val().trim() == '' || eval($(this).find('.targetObj').val()) == 0) {
                        var validateMessage = 'Vui lòng chọn ' + $(this).attr('ValidateMessage'); //lấy thông tin cần hiện
                        defaults.showErrorInCombo($(this), validateMessage);
                        lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                        if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                        return;
                    }
                    return;
                }
            });
        };        

        // Check select form đăng tin
        var BXHSelectAutoPost = function () {
            $('#' + objInstantID + ' .bxhSelectValidate').each(function () {
                if ($(this).hasClass('bxhSelectAutoPostRequire')) {
                    defaults.cleanError(this);
                    var validateMessage = 'Vui lòng chọn ' + $(this).attr('ValidateMessage');//lấy thông tin cần hiện
                    if ($(this).find(".cb_required").length > 0 && (eval($(this).find(".cb_required").val().trim()) == 0 || $(this).find(".cb_required").val().trim() == '')) {
                        defaults.showErrorInCombo($(this), validateMessage);
                        lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                        if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                        return;
                    }
                }
            });
        };

        // check có đồng ý với điều khoản của BXH khi đăng ký
        var CheckConfirmReg = function() {
            $('#' + objInstantID + ' .bxhConfirmValidate').each(function() {
                if ($(this).hasClass('bxhConfirmValidateRequired')) {
                    defaults.cleanError(this); //xóa validate lỗi                    
                    if (!$(this).is(":checked")) {
                        alert("Bạn chưa đồng ý với các điều khoản của Banxehoi.com");
                        lsObjIDError += $(this).attr('id') + ','; //thêm vào list các id bị lỗi
                        if ($(this).offset().top < errorTopPosition) errorTopPosition = $(this).offset().top;
                        return;
                    }
                }
            });

        };                
        
        this.ValidateProcessing = function () {
            lsObjIDError = ''; //khởi tạo lại 
            errorTopPosition = 999999;
            $('#' + objInstantID + ' .bxhInputValidate').trigger('blur'); /*gọi các sự kiện khi thoát khỏi textbox để kiểm tra các điều kiện*/
            BXHComboValidate();
            BXHSelectOption();
            BXHAutoCompleteCityComboValidate();
            CheckConfirmReg();
            //Check select Form Đăng tin
            BXHSelectAutoPost();
        };

        this.IsValidate = function() {
            return lsObjIDError == '';
        };
        
        $('#' + objInstantID + ' .bxhvalidatesumit').click(function () {
            _this.ValidateProcessing();
            if (!_this.IsValidate()) {
                $(window).scrollTop(errorTopPosition);
                return false;
            }
            if (defaults.funcOnClick != null) {                
                return defaults.funcOnClick();
            }
            return true;
        });        
    });
    return this;
};
