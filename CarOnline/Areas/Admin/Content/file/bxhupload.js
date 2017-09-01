$.fn.bxhupload = function (parameters) {
    var instanceID = $(this).attr('id');
    var isIE7 = false;
    if (navigator.appVersion.indexOf("MSIE 6.") != -1
        || navigator.appVersion.indexOf("MSIE 7.") != -1
        || navigator.appVersion.indexOf("MSIE 8.") != -1
        || navigator.appVersion.indexOf("MSIE 9.") != -1)
    {
        isIE7 = true;
    }
    var isInit = true;
    var defaults = $.extend({
        theme: 'default-theme',
        pluginFolder: '/Plugins/BXHUpload',
        fileSize: 6,
        serverThumb: 'https://img1.banxehoi.com',
        serverUpload: 'https://upload.banxehoi.com',
        maxFiles: 3,
        itemWidth: 127,
        itemHeight: 95,
        rotateActionName: 'rotate/',
        rotate90ActionName: 'rotate/90/',
        rotate180ActionName: 'rotate/180/',
        rotate270ActionName: 'rotate/270/',
        uploadSingle: false
    }, parameters);
    var initOpenFileBrowser = function () {
        $('#' + instanceID + ' .upload-item').unbind('click');
        $('#' + instanceID + ' .working-upload-item').click(function () {
            $('#' + instanceID + ' .fileupload').click();
        });

    }
    var initOpenFileBrowserSingle = function () {
        $('#' + instanceID + ' #uploadsingle0').click(function () {
            $('#' + instanceID + ' #fileuploadsingle0').click();
        });
        $('#' + instanceID + ' #uploadsingle1').click(function () {
            $('#' + instanceID + ' #fileuploadsingle1').click();
        });
        $('#' + instanceID + ' #uploadsingle2').click(function () {
            $('#' + instanceID + ' #fileuploadsingle2').click();
        });
        $('#' + instanceID + ' #uploadsingle3').click(function () {
            $('#' + instanceID + ' #fileuploadsingle3').click();
        });
    }
    var initActionImage = function () {
        //tạo sự kiện xóa và xoay
        $('#' + instanceID + ' .upload-item .upload-item-delete').unbind('click');
        $('#' + instanceID + ' .upload-item .upload-item-delete').click(function () {
            var image = $(this).parent().attr('rel');
            var listImage = removeImage2List($('#' + parameters.target).val(), image);
            $('#' + parameters.target).val(listImage);
            $(this).parent().remove();
            if (!isIE7) {
                //nếu xóa xong mà chưa có cái nào để upload thì phải show ra 1 cái
                if ($('#' + instanceID + ' .working-upload-item').length == 0) {
                    $('#' + instanceID).append(uploadItemTemplate);
                    initOpenFileBrowser();
                }
            }
            else
            {
                //nếu xóa xong mà chưa có cái nào để upload thì phải show ra 1 cái
                if ($('#' + instanceID + ' .working-upload-item').length == 0) {
                    $('#' + instanceID).append(uploadItemTemplateIE7);
                    createEvenForControlIE7();
                }
            }
        });
        $('#' + instanceID + ' .upload-item .upload-item-rotate').unbind('click');
        $('#' + instanceID + ' .upload-item .upload-item-rotate').click(function () {
            var image = $(this).parent().attr('rel');
            var newimage = '';
            if (image.indexOf(defaults.rotateActionName) == -1) newimage = defaults.rotate90ActionName + image;
            else if (image.indexOf(defaults.rotate90ActionName) != -1) newimage = defaults.rotate180ActionName + image.replace(defaults.rotate90ActionName, '');
            else if (image.indexOf(defaults.rotate180ActionName) != -1) newimage = defaults.rotate270ActionName + image.replace(defaults.rotate180ActionName, '');
            else if (image.indexOf(defaults.rotate270ActionName) != -1) newimage = image.replace(defaults.rotate270ActionName, '');
            var listImage = replaceImage2List($('#' + parameters.target).val(), image, newimage);            
            $('#' + parameters.target).val(listImage);            
            if (!isIE7) {
                $(this).parent().attr('style', 'background:url(\'' + defaults.serverThumb + '/' + newimage + '\')  no-repeat scroll 0% 0% / ' + defaults.itemWidth + 'px ' + defaults.itemHeight + 'px transparent;');
                $(this).parent().attr('rel', newimage); //dùng làm data cho sự kiện xóa và xoay
            }
            else {
                $(this).parent().find('.background').remove();
                $(this).parent().append('<img class="background" src="' + defaults.serverThumb + '/' + newimage + '"/>');
                $(this).parent().attr('rel', newimage); //dùng làm data cho sự kiện xóa và xoay
            }
        });
    }
    var loadTargetBySort = function (event, ui) {
        var listImage = '';
        for (var i = 0; i < $('#' + instanceID + ' > div.uploadsortable').length; i++) {
            var urlImage = $('#' + instanceID + ' > div.uploadsortable:eq(' + i + ')').css('background-image');
            urlImage = urlImage.replace(/[()"]/g, '');
            urlImage = urlImage.replace('url' + defaults.serverThumb, '');
            if (urlImage != null && urlImage != '' && urlImage != 'none') {
                if (listImage == '') listImage = urlImage;
                else listImage = listImage + ',' + urlImage;
            }
        }
        $('#' + parameters.target).val(listImage);
    }
    var bxhuploadfinish = function (imageURL) {
        //khi post data xong trả về đường dẫn ảnh và đẩy nó vào div hiển thị
        $('#' + instanceID + ' .working-upload-item').removeClass('upload-item-loading').addClass('uploadsortable');
        $('#' + instanceID + ' .working-upload-item').attr('style', 'background:url(\'' + defaults.serverThumb + '/' + imageURL + '\')  no-repeat scroll 0% 0% / ' + defaults.itemWidth + 'px ' + defaults.itemHeight + 'px transparent;');
        $('#' + instanceID + ' .working-upload-item').attr('rel', imageURL); //dùng làm data cho sự kiện xóa và xoay
        $('#' + instanceID + ' .working-upload-item').append(actionItemTemplate); //thêm 2 nút xóa và xoay

        $('#' + instanceID + ' .working-upload-item').removeClass('working-upload-item').after(uploadItemTemplate);//chuyển box upload hiện thời thành box upload mới
        initOpenFileBrowser(); //tạo sự kiện mở file

        initActionImage();//thêm sự kiện cho 2 nút xóa và xoay

        $('#' + instanceID).sortable({ items: "div.uploadsortable", update: loadTargetBySort });
        $('#' + instanceID).disableSelection();
    }
    var bxhuploadfinishsingle = function (imageURL, target) {
        //khi post data xong trả về đường dẫn ảnh và đẩy nó vào div hiển thị
        $('#' + instanceID + ' #' + target).removeClass('upload-item-single').addClass('upload-item').removeClass('upload-item-loading').addClass('uploadsortable');
        $('#' + instanceID + ' #' + target).attr('style', 'background:url(\'' + defaults.serverThumb + '/' + imageURL + '\')  no-repeat scroll 0% 0% / ' + defaults.itemWidth + 'px ' + defaults.itemHeight + 'px transparent;');
        $('#' + instanceID + ' #' + target).html('');
        $('#' + instanceID + ' #' + target).attr('rel', imageURL); //dùng làm data cho sự kiện xóa và xoay
        $('#' + instanceID + ' #' + target).append(actionItemTemplate); //thêm 2 nút xóa và xoay
        $('#' + instanceID + ' #' + target).unbind('click');
        initActionImage();//thêm sự kiện cho 2 nút xóa và xoay
        $('#' + instanceID).sortable({ items: "div.uploadsortable", update: loadTargetBySort });
        $('#' + instanceID).disableSelection();
    }
    var bxhuploadfinishIE7 = function (imageURL) {
        //khi post data xong trả về đường dẫn ảnh và đẩy nó vào div hiển thị
        $('#' + instanceID + ' .working-upload-item').removeClass('upload-item-loading');
        $('#postiframe').remove();
        $('#theuploadform').remove();
        $('#' + instanceID + ' .working-upload-item').append('<img class="background" src="' + defaults.serverThumb + '/' + imageURL + '"/>');
        $('#' + instanceID + ' .working-upload-item').attr('rel', imageURL);//dùng làm data cho sự kiện xóa và xoay
        $('#' + instanceID + ' .working-upload-item').append(actionItemTemplate);//thêm 2 nút xóa và xoay
        $('#' + instanceID + ' .working-upload-item').removeClass('working-upload-item').after(uploadItemTemplateIE7);//chuyển box upload hiện thời thành box upload mới

        createEvenForControlIE7(); //tạo control fileupload chèn vào div

        initActionImage();//thêm sự kiện cho 2 nút xóa và xoay
    }
    var validateImage = function (file)
    {
        //check size
        if (file.size > eval(defaults.fileSize * 1024 * 1024)) return "Kích thước ảnh quá lớn. Dũng lượng ảnh phải nhỏ hơn " + defaults.fileSize + " Mb";
        //check type
        var ext = file.name.split('.').pop().toLowerCase();
        if ($.inArray(ext, ['gif', 'png', 'jpg', 'jpeg']) == -1) {
            return 'Không đúng định dạng ảnh cho phép (gif, png, jpg, jpeg)';
        }
        return "";
    }
    var successPost = function (imgURL) {
        var listImage = '';
        bxhuploadfinish(imgURL);
        listImage = addImage2List($('#' + parameters.target).val(), imgURL);
        $('#' + parameters.target).val(listImage);
    }
    var successPostIE7 = function (imgURL) {
        var listImage = '';
        bxhuploadfinishIE7(imgURL);
        listImage = addImage2List($('#' + parameters.target).val(), imgURL);
        $('#' + parameters.target).val(listImage);
    }
    var successSinglePost = function (imgURL, target) {
        var listImage = '';
        bxhuploadfinishsingle(imgURL, target);
        listImage = addImage2ListSingle($('#' + parameters.target).val(), imgURL, eval(target.replace('uploadsingle', '')));
        $('#' + parameters.target).val(listImage);
    }
    var createEvenForControlIE7 = function () {
        isInit = true;//do cái postiframe khi được append sẽ gọi load luôn. lên lần đầu chưa có gì để thực thi phải dùng cờ này để cản lại
        $('#fileToUpload').on('change', function () {
            //sau khi chọn file xong thì submit form
            $("#theuploadform").submit();
        });
        $("#postiframe").load(function () {
            //lần đầu mà đang khởi tạo sẽ không vào
            //chạy lần đâu xong thì chuyển init thành false đề lần sau chọn file là vào
            if (!isInit) {
                var imgURL = this.contentWindow.document.body.innerHTML.replace("<pre>", "").replace("</pre>", "").replace("<PRE>", "").replace("</PRE>", "");
                if (imgURL == 'error') {
                    alert('Có lỗi xảy ra, xin bạn vui lòng upload lại ảnh');
                    return;
                }
                successPostIE7(imgURL);
                if (isNumberOfImageOverload()) {
                    //nếu số lượng ảnh đã load đủ vào các item, thì không cần thêm cái upload nữa.
                    $('#' + instanceID + ' .working-upload-item').remove();
                }
            }
            else {
                isInit = false;
            }
        });
    }
    var isNumberOfImageOverload = function () {
        //kiểm tra số lượng ảnh trong trường hợp chọn nhiều ảnh hơn được phép
        var arrListImage = $('#' + parameters.target).val() == '' ? "" : $('#' + parameters.target).val().split(",");
        if (arrListImage.length >= defaults.maxFiles) {
            return true;
        }
        return false
    }
    //init
    $('#' + instanceID).addClass(defaults.theme);
    var uploadItemTemplate = '<div class="upload-item working-upload-item"></div>';
    var uploadItemTemplateIE7 = '<div class="upload-item working-upload-item"><iframe name="postiframe" id="postiframe" style="display: none"></iframe><form id="theuploadform" action="/UploadHandler.ashx" method="post" encoding="multipart/form-data" enctype="multipart/form-data" target="postiframe"><input multiple class="fileuploadie7" type="file" id="fileToUpload" name="userfile"/></form></div>';
    var actionItemTemplate = '<a href="javascript:void(0)" class="upload-item-delete" rel="nofollow"><img src="' + defaults.pluginFolder + '/images/blank.gif"/></a><a href="javascript:void(0)" class="upload-item-rotate"><img src="' + defaults.pluginFolder + '/images/blank.gif"/></a>';
    if (!isIE7) {
        if ($('#' + parameters.target).val() == '' && defaults.uploadSingle) {
            //nếu chưa có ảnh nào
            $(this).append('<input id="fileuploadsingle0" class="fileuploadsingle" type="file" style="display:none" name="userfile" target="uploadsingle0"/>');
            $(this).append('<div class="upload-item-single" id="uploadsingle0"><img src="' + defaults.pluginFolder + '/images/1-upload.png" /></div>');

            $(this).append('<input id="fileuploadsingle1" class="fileuploadsingle" type="file" style="display:none" name="userfile" target="uploadsingle1"/>');
            $(this).append('<div class="upload-item-single" id="uploadsingle1"><img src="' + defaults.pluginFolder + '/images/2-upload.png" /></div>');

            $(this).append('<input id="fileuploadsingle2" class="fileuploadsingle" type="file" style="display:none" name="userfile" target="uploadsingle2"/>');
            $(this).append('<div class="upload-item-single" id="uploadsingle2"><img src="' + defaults.pluginFolder + '/images/3-upload.png" /></div>');

            $(this).append('<input id="fileuploadsingle3" class="fileuploadsingle" type="file" style="display:none" name="userfile" target="uploadsingle3"/>');
            $(this).append('<div class="upload-item-single" id="uploadsingle3"><img src="' + defaults.pluginFolder + '/images/4-upload.png" /></div>');
        }

        $(this).append('<input multiple class="fileupload input-hidden" type="file"/>');
        $(this).append(uploadItemTemplate);

        if ($('#' + parameters.target).val() != '') {
            //nếu là postback, đã có up ảnh từ lần trước        
            var arrListImage = $('#' + parameters.target).val() == '' ? "" : $('#' + parameters.target).val().split(",");
            for (var i = 0; i < arrListImage.length; i++) {
                bxhuploadfinish(arrListImage[i]);
            }
            //nếu số lượng ảnh đã load đủ vào các item, thì không cần thêm cái upload nữa, xẩy ra khi số lượng ảnh đã post back đúng bằng qouta
            if (isNumberOfImageOverload()) {
                $('#' + instanceID + ' .working-upload-item').remove();
            }
        }
        else {
            initOpenFileBrowser();
            initOpenFileBrowserSingle();
        }
    }
    else {
        $(this).append('<div>Xin vui lòng sử dụng trình duyệt Firefox hoặc Chrome để được hỗ trợ upload ảnh</div>');
        /*
        $(this).append(uploadItemTemplateIE7);
        if ($('#' + parameters.target).val() != '') {
            var arrListImage = $('#' + parameters.target).val() == '' ? "" : $('#' + parameters.target).val().split(",");
            for (var i = 0; i < arrListImage.length; i++) {
                bxhuploadfinishIE7(arrListImage[i]);
            }
            if (isNumberOfImageOverload()) {
                $('#' + instanceID + ' .working-upload-item').remove();
            }
        }
        else {            
            createEvenForControlIE7();
        }
        */
    }
    
    //endinit
    var addImage2List = function (list, newimage)
    {
        if (list == '') return newimage;
        var arrListImage = list.split(",");
        for (var i = 0; i < arrListImage.length; i++)
        {
            if (newimage == arrListImage[i]) return list;
        }
        return list + ',' + newimage;
    }
    var addImage2ListSingle = function (list, newimage, index) {
        var objID = '#uploadsingle' + index;
        if (list == '') return newimage;
        var arrListImage = list.split(",");
        for (var i = 0; i < arrListImage.length; i++) {
            if (newimage == arrListImage[i]) return list;
        }
        var newlist = '';

        //kiểm tra lại vị trị thật sự của div này hiện giờ
        for (var i = 0; i < $(objID).parent().children('div').length - 1; i++) {
            if ($(objID).parent().children('div:eq(' + i + ')').attr('id') == 'uploadsingle' + index) {
                //nếu vẫn là dạng ảnh mặc định thì
                index = i;
                break;
            }
        }

        //kiểm tra các vị trí trước nó đã insert chưa, nếu chưa thì index giảm đi 1
        //vì ví dụ có 4 vị trí, cần insert vào vị trí 3, thì tìm 1,2 có chưa nếu chưa có thì index trừ 2 bằng 1 tức là vị trí đầu tiên.
        var currentIndex = index;
        for (var i = 0; i < currentIndex; i++) {
            if (!$(objID).parent().children('div:eq(' + i + ')').hasClass('uploadsortable')) {
                //nếu vẫn là dạng ảnh mặc định thì
                index--;
            }
        }

        
        if (index == 0) {
            return newimage + ',' + list;
        }
        else if (index == arrListImage.length) {
            return list + ',' + newimage;
        }
        else {
            for (var i = 0; i < arrListImage.length; i++) {
                if (i == index) newlist = newlist + ',' + newimage; //chèn vào vị trí index, nếu index không phải không phải đầu tiền

                //chèn các item đã có vào
                if (i == 0) newlist = arrListImage[i];
                else newlist = newlist + ',' + arrListImage[i];
            }
            return newlist;
        }
    }
    var removeImage2List = function (list, currentimage) {
        if (list == '') return '';
        var arrListImage = list.split(",");
        var newlist = '';
        for (var i = 0; i < arrListImage.length; i++) {
            if (currentimage != arrListImage[i]) newlist += (newlist != ''?',':'') + arrListImage[i];
        }
        return newlist.trim();
    }
    var replaceImage2List = function (list, currentimage, newimage) {
        if (list == '') return '';
        var arrListImage = list.split(",");
        var newlist = '';
        for (var i = 0; i < arrListImage.length; i++) {
            if (currentimage != arrListImage[i]) {
                newlist += (newlist != '' ? ',' : '') + arrListImage[i];
            }
            else {
                newlist += (newlist != '' ? ',' : '') + newimage;
            }
        }
        return newlist.trim();
    }
    $('#' + instanceID + ' .fileupload').on('change', function () {
        //sau khi chọn file xong thì submit form
        if(this.files.length > 0)
        {
            var isFail = false;
            for (i = 0; i < this.files.length; i++) {
                if (isFail) break; //nếu có lỗi khi upload ảnh thì thoát ra tại thời điểm đó
                //kiểm tra dung lượng và loại
                var errImage = validateImage(this.files[i]);
                if (errImage != '')
                {
                    alert(errImage);
                    continue;
                }
                if (isNumberOfImageOverload())
                {
                    alert('Bạn đã upload quá ' + defaults.maxFiles + ' ảnh');
                    //nếu số lượng ảnh đã load đủ vào các item, thì không cần thêm cái upload nữa.
                    $('#' + instanceID + ' .working-upload-item').remove();
                    break;
                }
                var data = new FormData();
                data.append('id', 'TTR');
                data.append('fileToUpload', this.files[i]);
                data.append('project', 'banxehoi');
                data.append('UploadType', 'upload');
                data.append('StringDecypt', parameters.token);
                data.append('submit', 'Upload Image');
                $.ajax({
                    url: defaults.serverUpload + '/UploadHandler.php',
                    type: 'POST',
                    data: data,
                    cache: false,
                    dataType: 'json',
                    async: false,
                    processData: false, // Don't process the files
                    contentType: false, // Set content type to false as jQuery will tell the server its a query string request
                    beforeSend: function () {
                        $('#' + instanceID + ' .working-upload-item').addClass('upload-item-loading');
                    },
                    success: function (data) {
                        successPost(data.OK);
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        alert('Có lỗi xảy ra, xin bạn vui lòng upload lại ảnh');
                        $('#' + instanceID + ' .working-upload-item').removeClass('upload-item-loading');
                        isFail = true;
                    }
                });                
            }
        }
        if (isNumberOfImageOverload()) {
            //nếu số lượng ảnh đã upload bằng đúng đủ qouta, thì không cần thêm cái upload nữa.
            $('#' + instanceID + ' .working-upload-item').remove();            
        }
    });
    $('#' + instanceID + ' .fileuploadsingle').on('change', function () {
        //sau khi chọn file xong thì submit form
        var target = $(this).attr('target');
        if (this.files.length > 0) {
            //kiểm tra dung lượng và loại
            var errImage = validateImage(this.files[0]);
            if (errImage != '') {
                alert(errImage);
                return;
            }
            if (isNumberOfImageOverload()) {
                alert('Bạn đã upload quá ' + defaults.maxFiles + ' ảnh');
                //nếu số lượng ảnh đã load đủ vào các item, thì không cần thêm cái upload nữa.
                $('#' + instanceID + ' .working-upload-item').remove();
                return;
            }
            var templateImage = $('#' + instanceID + ' #' + target).html();
            var data = new FormData();
            data.append('id', 'TTR');
            data.append('fileToUpload', this.files[0]);
            data.append('project', 'banxehoi');
            data.append('UploadType', 'upload');
            data.append('StringDecypt', parameters.token);
            data.append('submit', 'Upload Image');
            $.ajax({
                url: defaults.serverUpload + '/UploadHandler.php',
                type: 'POST',
                data: data,
                cache: false,
                dataType: 'json',
                async: false,
                processData: false, // Don't process the files
                contentType: false, // Set content type to false as jQuery will tell the server its a query string request
                beforeSend: function () {
                    $('#' + instanceID + ' #' + target).addClass('upload-item-loading').html('');
                },
                success: function (data) {
                    successSinglePost(data.OK, target);
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert('Có lỗi xảy ra, xin bạn vui lòng upload lại ảnh');
                    $('#' + instanceID + ' #' + target).removeClass('upload-item-loading').html(templateImage);
                }
            });
        }
    });
}