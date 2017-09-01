//dang ky chat
var strChatRegTempalte = "<script id=\"chat-reg-tempalte\" type=\"text/x-jquery-tmpl\">";
strChatRegTempalte += "  <div class=\"chat-reg\">";
strChatRegTempalte += "        <div class=\"chatPopup-header\">";
strChatRegTempalte += "            <span class=\"header-title\">";
strChatRegTempalte += "                <div class=\"${bdsClass}\">";
strChatRegTempalte += "                    <span class=\"user-status online-status\"><\/span>";
strChatRegTempalte += "                    <span class=\"link-chat-bds-header ${bdsIconClass}\"><\/span>";
strChatRegTempalte += "                    <span>${fullName}<\/span>";
strChatRegTempalte += "                <\/div>";
strChatRegTempalte += "            <\/span>";
strChatRegTempalte += "            <div class=\"header-icon\">";
strChatRegTempalte += "                <a class=\"header-icon-close\" title=\"Đóng\" href=\"javascript:void(0)\">";
strChatRegTempalte += "                    <span><\/span>";
strChatRegTempalte += "                <\/a>";
strChatRegTempalte += "                <a class=\"header-icon-minimize\" title=\"\" href=\"javascript:void(0)\">";
strChatRegTempalte += "                    <span><\/span>";
strChatRegTempalte += "                <\/a>";
strChatRegTempalte += "            <\/div>";
strChatRegTempalte += "            <div class=\"clear\"><\/div>";
strChatRegTempalte += "        <\/div>";


strChatRegTempalte += "        <div class=\"chatRoom\">";

strChatRegTempalte += "                <div class=\"chat-header\">";
strChatRegTempalte += "                   Vui lòng điền các thông tin dưới đây để chúng tôi hỗ trợ bạn được tốt hơn !";
strChatRegTempalte += "                <\/div>";

strChatRegTempalte += "            <div class=\"chat-reg-form\">";
strChatRegTempalte += "                <input type=\"hidden\" value=\"${userId}\" id=\"txtChatUserId\" \/>";
strChatRegTempalte += "                <input type=\"hidden\" value=\"${productId}\" id=\"txtChatProductId\" \/>";
strChatRegTempalte += "                <div class=\"chat-user-info\">";
strChatRegTempalte += "                    <div id=\"regMessage\" style=\"color: red; font-weight: bold;\"><\/div>";
strChatRegTempalte += "                    <div>";

strChatRegTempalte += "                        <span>";
strChatRegTempalte += "                            <input placeholder=\"Số điện thoại (*)\"  type=\"text\" id=\"txtChatPhoneNumber\" \/><\/span>";
strChatRegTempalte += "                    <\/div>";

strChatRegTempalte += "                    <div>";

strChatRegTempalte += "                        <span>";
strChatRegTempalte += "                            <input placeholder=\"Tên (*)\" maxlength=\"100\"  type=\"text\" id=\"txtChatName\" \/><\/span>";
strChatRegTempalte += "                    <\/div>";
strChatRegTempalte += "                    <div style=\"display:none\">";
strChatRegTempalte += "                        <span class=\"chat-user-info-gender\">Giới tính: <span class=\"chat-reg-required\">(*)<\/span><\/span>";
strChatRegTempalte += "                        <span class=\"chat-user-gender-radio\"> ";
strChatRegTempalte += "                            <input value=\"1\" name=\"rdGender\" type=\"radio\" id=\"rdGender_rdMale\" \/><label for=\"rdGender_rdMale\"> Nam</label>";
strChatRegTempalte += "                            <input value=\"2\" type=\"radio\" name=\"rdGender\" id=                  \"rdGender_rdFeMale\" \/><label for=\"rdGender_rdFeMale\"> Nữ</label>";
strChatRegTempalte += "<\/span>";
strChatRegTempalte += "                    <\/div>";
strChatRegTempalte += "                    <div>";


strChatRegTempalte += "                        <span>";
strChatRegTempalte += "                            <input placeholder=\"Email (*)\"  type=\"text\" id=\"txtChatEmail\" \/><\/span>";
strChatRegTempalte += "                    <\/div>";
strChatRegTempalte += "                    <div>";


strChatRegTempalte += "                        <p class=\"catpcha_container\">    <input id=\"hidCaptchaId\" type=\"hidden\" value=\"CAPTCHA_RESULT_123456\">";
strChatRegTempalte += "                            <img id=\"img_CAPTCHA_RESULT_123456\" alt=\"\" noloaderror=\"1\" src=\"\/chat/GenerateCaptcha?t=221\" style=\"height: 23px; width: 50px; vertical-align: -6px;\">";
strChatRegTempalte += "                            <img id=\"reloadCaptcha\" class=\"reloadCapcha\" src=\"\/Content\/Chat\/styles\/images\/icon-reload.png\" alt=\"renew capcha\" title=\"Đổi mã an toàn\" onclick=\"javascript:refreshCaptcha('img_CAPTCHA_RESULT_123456');\" onmouseover=\"this.style.cursor='pointer'\" style=\"cursor: pointer; height: 18px; width: 18px; vertical-align: -4px;\">";
strChatRegTempalte += "                        <\/span></p>";

strChatRegTempalte += "                        <span>";
strChatRegTempalte += "                            <input placeholder=\"Mã an toàn (*)\" type=\"text\" id=\"txtChatCapchar\" \/><\/span>";
strChatRegTempalte += "                        <span>";

strChatRegTempalte += "                    <\/div>";
strChatRegTempalte += "                <\/div>";
strChatRegTempalte += "                <div class=\"chat-login\">";
strChatRegTempalte += "                    Hoặc <a class=\"fancybox.ajax\" id=\"dangnhap_chat\" rel=\"nofollow\" href=\"/member/login\">đăng nhập<\/a> để được hưởng nhiều tiện ích hơn!";
strChatRegTempalte += "                <\/div>";
strChatRegTempalte += "                <div class=\"chat-reg-save-info\">";
strChatRegTempalte += "                    <input type=\"hidden\" id=\"chkChatSaveInfo\" value=\"1\">";
strChatRegTempalte += "                    <span>Lưu thông tin cá nhân<\/span>";
strChatRegTempalte += "                <\/div>";
strChatRegTempalte += "                <div class=\"chat-reg-button\">";
strChatRegTempalte += "                    <input type=\"button\" value=\"Bắt đầu chat\" id=\"btnStartChat\" \/>";
strChatRegTempalte += "                    <input type=\"button\" value=\"Nhập lại\" id=\"btnChatClear\" \/>";
strChatRegTempalte += "                <\/div>";
strChatRegTempalte += "            <\/div>";
strChatRegTempalte += "        <\/div>";
strChatRegTempalte += "    <\/div>";
strChatRegTempalte += "    <\/script>";

var strNewOnlineContact = "";
strNewOnlineContact += "<script id=\"new-online-contacts\" type=\"text\/x-jquery-tmpl\">";
strNewOnlineContact += "    <div>";
strNewOnlineContact += "        <ul>";
strNewOnlineContact += "            {{each users}}";
strNewOnlineContact += "        <li id=\"chatLink-${UserId}\"><a href=\"javascript:;\" onclick=\"javascript:BDSChat.initiateChat('${UserId}','0');\">${FullName}<\/a><\/li>";
strNewOnlineContact += "            {{\/each}}";
strNewOnlineContact += "        <\/ul>";
strNewOnlineContact += "    <\/div>";
strNewOnlineContact += "<\/script>";

var strNewChatroomTemplate = "";
strNewChatroomTemplate += "<script id=\"new-chatroom-template\" type=\"text\/x-jquery-tmpl\">";
strNewChatroomTemplate += "    <div id=\"chatRoom-${chatRoomId}\" class=\"chatRoom\">";
strNewChatroomTemplate += "        <div id=\"messages-${chatRoomId}\" class=\"chatMessages\">";
strNewChatroomTemplate += "        <\/div>";
strNewChatroomTemplate += "        <div class=\"clear\"><\/div>";
strNewChatroomTemplate += "        <form id=\"sendmessage-${chatRoomId}\" action=\"#\">";
strNewChatroomTemplate += "            <div class=\"sendmessage-container\">";
strNewChatroomTemplate += "                <div class=\"chat-command\">";
strNewChatroomTemplate += "                    <div class=\"text-newmessage\">";
strNewChatroomTemplate += "                        <textarea type=\"text\" id=\"newmessage-${chatRoomId}\" class=\"chatNewMessage\" placeholder=\"Nhập nội dung và nhấn &quot;enter&quot; để chat\" onkeyup=\"autoResizeTextArea(this)\" onkeydown=\"return chatTextEnter(this, event);\"><\/textarea>";
strNewChatroomTemplate += "                        <input type=\"button\" id=\"chatsend-${chatRoomId}\" value=\"Send\" class=\"chatSend\" onclick=\"javascript: BDSChat.sendChatMessage('${chatRoomId}')\" \/>";
strNewChatroomTemplate += "                    <\/div>";
strNewChatroomTemplate += "                    <div class=\"div-emoticon\">";
strNewChatroomTemplate += "                        <span id=\"pnlEmoticions-${chatRoomId}\" class=\"emoticon-0100-smile emoticon-avatar\" rel=\":)\"><\/span>";
strNewChatroomTemplate += "                    <\/div>";
strNewChatroomTemplate += "                <\/div>";
strNewChatroomTemplate += "            <\/div>";
strNewChatroomTemplate += "        <\/form>";
strNewChatroomTemplate += "        <div class=\"clear\"><\/div>";
strNewChatroomTemplate += "    <\/div>";
strNewChatroomTemplate += "<\/script>";

var strNewChatHeader = "";
strNewChatHeader += "<script id=\"new-chat-header\" type=\"text\/x-jquery-tmpl\">";
strNewChatHeader += "    <div id=\"chatRoomHeader-${chatRoomId}\">";
strNewChatHeader += "        {{each chatUsers}}";
strNewChatHeader += "            {{if !BDSChat.isCurrentUser(UserId)}}";
strNewChatHeader += "                {{if IsStaff}}";
strNewChatHeader += "                    <span class=\"user-status\"><\/span><span class=\"chat-fullname\">Tư vấn trực tuyến<\/span>";
strNewChatHeader += "";
strNewChatHeader += "        {{else}}";
strNewChatHeader += "                    <span class=\"user-status\"><\/span><span class=\"chat-fullname\">{{html BDSChat.formatName(FullName, 15)}}<\/span>";
strNewChatHeader += "        {{\/if}}";
strNewChatHeader += "                <span class=\"unread-count\"><\/span>";
strNewChatHeader += "        {{\/if}}";
strNewChatHeader += "        {{\/each}}";
strNewChatHeader += "    <\/div>";
strNewChatHeader += "<\/script>";

var strNewMessageTemplateLeft = "";
strNewMessageTemplateLeft += "<script id=\"new-message-template-left\" type=\"text\/x-jquery-tmpl\">";
strNewMessageTemplateLeft += "    <div class=\"message\" id=\"m-${chatMessageId}\" timestamp=\"${timestamp}\">";
strNewMessageTemplateLeft += "        <div class=\"left\">";
strNewMessageTemplateLeft += "            <a class=\"avatar\" href=\"#\">";
strNewMessageTemplateLeft += "                <img src=\"\" alt=\"\" \/><\/a>";
strNewMessageTemplateLeft += "            <div class=\"msg-text-item\">";
strNewMessageTemplateLeft += "                <div class=\"bounds\">";
strNewMessageTemplateLeft += "                    <div class=\"text-message\">";
strNewMessageTemplateLeft += "                        <span>{{html messageText}}";
strNewMessageTemplateLeft += "                        <\/span>";
strNewMessageTemplateLeft += "                    <\/div>";
strNewMessageTemplateLeft += "                <\/div>";
strNewMessageTemplateLeft += "            <\/div>";
strNewMessageTemplateLeft += "        <\/div>";
strNewMessageTemplateLeft += "        <div class=\"clear\"><\/div>";
strNewMessageTemplateLeft += "    <\/div>";
strNewMessageTemplateLeft += "<\/script>";

var strNewMessageTemplateRight = "";
strNewMessageTemplateRight += "<script id=\"new-message-template-right\" type=\"text\/x-jquery-tmpl\">";
strNewMessageTemplateRight += "    <div class=\"message\" id=\"m-${chatMessageId}\" timestamp=\"${timestamp}\">";
strNewMessageTemplateRight += "        <div class=\"right ml43\">";
strNewMessageTemplateRight += "            <div class=\"msg-text-item\">";
strNewMessageTemplateRight += "                <div class=\"bounds\">";
strNewMessageTemplateRight += "                    <div class=\"text-message\">";
strNewMessageTemplateRight += "                        <span>{{html messageText}}";
strNewMessageTemplateRight += "                        <\/span>";
strNewMessageTemplateRight += "                    <\/div>";
strNewMessageTemplateRight += "                <\/div>";
strNewMessageTemplateRight += "            <\/div>";
strNewMessageTemplateRight += "        <\/div>";
strNewMessageTemplateRight += "        <div class=\"clear\"><\/div>";
strNewMessageTemplateRight += "    <\/div>";
strNewMessageTemplateRight += "<\/script>";

var strNewNotifyMessageTemplate = "";
strNewNotifyMessageTemplate += "<script id=\"new-notify-message-template\" type=\"text\/x-jquery-tmpl\">";
strNewNotifyMessageTemplate += "    <div class=\"message\" id=\"m-${chatMessageId}\">";
strNewNotifyMessageTemplate += "        <strong>{{html messageText}}<\/strong>";
strNewNotifyMessageTemplate += "    <\/div>";
strNewNotifyMessageTemplate += "<\/script>";

var strNewMessageTemplate = "";
strNewMessageTemplate += "<script id=\"new-message-template\" type=\"text\/x-jquery-tmpl\">";
strNewMessageTemplate += "    <div>";
strNewMessageTemplate += "        {{html messageText}}";
strNewMessageTemplate += "    <\/div>";
strNewMessageTemplate += "<\/script>";

var strChatPopupTemplate = "";
strChatPopupTemplate += "<script id=\"chat-popup-template\" type=\"text\/x-jquery-tmpl\">";
strChatPopupTemplate += "    <div class=\"chatPopup\" id=\"chatPopup-${id}\" roomid=\"${id}\" fullname=\"${fullName}\">";
strChatPopupTemplate += "    <\/div>";
strChatPopupTemplate += "<\/script>";

var strChatPopupHeaderTemplate = "";
strChatPopupHeaderTemplate += "<script id=\"chat-popup-header-template\" type=\"text\/x-jquery-tmpl\">";
strChatPopupHeaderTemplate += "    <div class=\"chatPopup-header\">";
strChatPopupHeaderTemplate += "        <span class=\"header-title\"><\/span>";
strChatPopupHeaderTemplate += "        <div class=\"header-icon\">";
strChatPopupHeaderTemplate += "            <a href=\"javascript:void(0)\" class=\"header-icon-close\" title=\"Đóng\"><span><\/span><\/a>";
strChatPopupHeaderTemplate += "            <!--<a href=\"javascript:void(0)\" class=\"header-icon-setting\"><span><\/span><\/a>-->";
strChatPopupHeaderTemplate += "            <a href=\"javascript:void(0)\" class=\"header-icon-minimize\" title=\"\"><span><\/span><\/a>";
strChatPopupHeaderTemplate += "";
strChatPopupHeaderTemplate += "        <\/div>";
strChatPopupHeaderTemplate += "        <div class=\"clear\"><\/div>";
strChatPopupHeaderTemplate += "    <\/div>";
strChatPopupHeaderTemplate += "";
strChatPopupHeaderTemplate += "<\/script>";

var strChatProductDetailsTemplate = "";
strChatProductDetailsTemplate += "<script id=\"chat-product-details-template\" type=\"text\/x-jquery-tmpl\">";
strChatProductDetailsTemplate += "    <div class=\"room-product-info\" productid=\"${ProductId}\" producttitle=\"${Title}\" ownerid=\"${UserId}\">";
strChatProductDetailsTemplate += "        <div class=\"room-product-info-img\">";
strChatProductDetailsTemplate += "            <img src=\"${ImageUrl}\" title=\"\" alt=\"\" \/>";
strChatProductDetailsTemplate += "        <\/div>";
strChatProductDetailsTemplate += "        <div class=\"room-product-info-content\">";
strChatProductDetailsTemplate += "            <div class=\"room-product-info-title\"><a href=\"${DetailUrl}\" title=\"\">${Title}<\/a><\/div>";
strChatProductDetailsTemplate += "        <\/div>";
strChatProductDetailsTemplate += "        <div class=\"room-product-info-contact\">Liên hệ:<span> ${Mobile}</span><\/div>";
strChatProductDetailsTemplate += "        <div class=\"clear\"><\/div>";
strChatProductDetailsTemplate += "        <\/div>";
strChatProductDetailsTemplate += "    <\/div>";
strChatProductDetailsTemplate += "<\/script>";

var strChatCallerBdsTemplate = "";
strChatCallerBdsTemplate += "<script id=\"chat-caller-bds-template\" type=\"text\/x-jquery-tmpl\">";
strChatCallerBdsTemplate += "    <div class=\"chat-caller-bds\">";
strChatCallerBdsTemplate += "        <table>";
strChatCallerBdsTemplate += "            <tr>";
strChatCallerBdsTemplate += "                <td rowspan=\"3\" style=\"padding-right: 5px; width: 70px; vertical-align: top;\">";
strChatCallerBdsTemplate += "                    <img class=\"support-avatar\" src=\"\/Content\/Chat\/Styles\/images\/support-avatar-default.png\" alt=\"\" title=\"\"><\/td>";
strChatCallerBdsTemplate += "                <td style=\"width: 122px;height:30px\"><span class=\"support-title\">${FullName}<\/span><\/td>";
strChatCallerBdsTemplate += "            <\/tr>";
strChatCallerBdsTemplate += "            <tr>";
strChatCallerBdsTemplate += "                <td  class=\"support-online-text\">${OnlineText}<\/td>";
strChatCallerBdsTemplate += "            <\/tr>";

strChatCallerBdsTemplate += "        <\/table>";
strChatCallerBdsTemplate += "        <div class=\"hr\">";
strChatCallerBdsTemplate += "        <\/div>";
strChatCallerBdsTemplate += "    <\/div>";
strChatCallerBdsTemplate += "<\/script>";

var strChatMessageErrorTemplate = "";
strChatMessageErrorTemplate += "<script id=\"chat-message-error-template\" type=\"text\/x-jquery-tmpl\">";
strChatMessageErrorTemplate += "    <div class=\"chat-message-error\">";
strChatMessageErrorTemplate += "        <table>";
strChatMessageErrorTemplate += "            <tr>";
strChatMessageErrorTemplate += "                <td class=\"error-icon\"><\/td>";
strChatMessageErrorTemplate += "                <td v-align=\"middle\">${messageText}";
strChatMessageErrorTemplate += "                <\/td>";
strChatMessageErrorTemplate += "            <\/tr>";
strChatMessageErrorTemplate += "        <\/table>";
strChatMessageErrorTemplate += "    <\/div>";
strChatMessageErrorTemplate += "<\/script>";

var strChatCollapseRoomTemplate = "";
strChatCollapseRoomTemplate += "<script id=\"chat-collapse-room-template\" type=\"text\/x-jquery-tmpl\">";
strChatCollapseRoomTemplate += "    <div class=\"collapse-chat-room\">";
strChatCollapseRoomTemplate += "        <div class=\"collapse-chat-room-header chat-header-bds\">";
strChatCollapseRoomTemplate += "            <a class=\"link-chat-bds\">";
strChatCollapseRoomTemplate += "                <span class=\"link-chat-bds-header\">";
strChatCollapseRoomTemplate += "                    <span class=\"link-chat-bds-header-number\">2<\/span>";
strChatCollapseRoomTemplate += "                <\/span>";
strChatCollapseRoomTemplate += "                <span class=\"link-chat-bds-content \">Danh sách đã chat <\/span><span  class=\"link-collapse-room-number\">(20)</span>";
strChatCollapseRoomTemplate += "            <\/a>";
strChatCollapseRoomTemplate += "            <div class=\"header-icon\">";
strChatCollapseRoomTemplate += "                <a href=\"javascript:void(0)\" class=\"header-icon-close\" title=\"Đóng\"><span><\/span><\/a>";
strChatCollapseRoomTemplate += "                <a href=\"javascript:void(0)\" class=\"header-icon-minimize\" title=\"\"><span><\/span><\/a>";
strChatCollapseRoomTemplate += "            <\/div>";
strChatCollapseRoomTemplate += "        <\/div>";
strChatCollapseRoomTemplate += "        <div class=\"collapse-room\">";
strChatCollapseRoomTemplate += "            <ul class=\"collapse-room-list\">";
strChatCollapseRoomTemplate += "            <\/ul>";
strChatCollapseRoomTemplate += "        <\/div>";
strChatCollapseRoomTemplate += "    <\/div>";
strChatCollapseRoomTemplate += "<\/script>";

var strChatCollapseRoomItemTemplate = "";
strChatCollapseRoomItemTemplate += "<script id=\"chat-collapse-room-item-template\" type=\"text\/x-jquery-tmpl\">";
strChatCollapseRoomItemTemplate += "    <li class=\"collapse-room-item\" id=\"collapse-room-item-${roomId}\" roomid=\"${roomId}\">";
strChatCollapseRoomItemTemplate += "        <a href=\"javascript:void(0)\">";
strChatCollapseRoomItemTemplate += "            <span>${fullName}<\/span>&nbsp;";
strChatCollapseRoomItemTemplate += "	    <span class=\"unread-count\"><\/span>";
strChatCollapseRoomItemTemplate += "        <\/a>";
strChatCollapseRoomItemTemplate += "    <\/li>";
strChatCollapseRoomItemTemplate += "<\/script>";

var strChatContainerTemplate = "";
strChatContainerTemplate += "<script id=\"chat-container-template\" type=\"text\/x-jquery-tmpl\">";
strChatContainerTemplate += "    <div class=\"list-chat-room\">";
strChatContainerTemplate += "        <div id=\"divChatWithBDS\">";
strChatContainerTemplate += "            <div class=\"chat-header-bds chat-with-bds\" id=\"chat-width-bds\">";
strChatContainerTemplate += "                <a class=\"link-chat-bds\" rel=\"nofollow\" href=\"javascript:void(0)\">";
strChatContainerTemplate += "                    <span class=\"link-chat-bds-header\"><\/span>";
strChatContainerTemplate += "                    <span class=\"link-chat-bds-content\">Chat với <b>Banxehoi.com<\/b><\/span>";
strChatContainerTemplate += "                <\/a>";
strChatContainerTemplate += "            <\/div>";
strChatContainerTemplate += "            <div class=\"lst-support\">";
strChatContainerTemplate += "                <ul>";
strChatContainerTemplate += "                <\/ul>";
strChatContainerTemplate += "            <\/div>";
strChatContainerTemplate += "        <\/div>";
strChatContainerTemplate += "    <\/div>";
strChatContainerTemplate += "<\/script>";

var strChatLstSupportTemplate = "";
strChatLstSupportTemplate += "<script id=\"chat-lst-support-template\" type=\"text\/x-jquery-tmpl\">";
strChatLstSupportTemplate += "    <li>";
strChatLstSupportTemplate += "        <a href=\"javascript:void(0)\" onclick=\"javascript:BDSChat.initiateChat('${UserId}', '0')\" uid=\"${UserId}\">";
strChatLstSupportTemplate += "            <span class=\"support-item-img\">";
strChatLstSupportTemplate += "                <img src=\"${AvatarUrl}\" alt=\"\" title=\"\"><\/span>";
strChatLstSupportTemplate += "            <span class=\"support-item-name \">${FullName}<\/span>";
strChatLstSupportTemplate += "            <span class=\"support-item-status ${IsOnline}\"><\/span>";
strChatLstSupportTemplate += "        <\/a>";
strChatLstSupportTemplate += "    <\/li>";
strChatLstSupportTemplate += "<\/script>";

var strChatLstSupportPartnerTemplate = "";
strChatLstSupportPartnerTemplate += "<script id=\"chat-lst-support-template\" type=\"text\/x-jquery-tmpl\">";
strChatLstSupportPartnerTemplate += "    <li>";
strChatLstSupportPartnerTemplate += "        <a href=\"javascript:void(0)\" onclick=\"javascript:BDSChat.initiateChat('${UserId}', '0')\" uid=\"${UserId}\">";
strChatLstSupportPartnerTemplate += "            <span class=\"support-item-img-partner\">";
strChatLstSupportPartnerTemplate += "                <img src=\"/Content/Chat/Styles/images/support-partner-avatar.png\" alt=\"\" title=\"\"><\/span>";
strChatLstSupportPartnerTemplate += "            <span class=\"support-item-name partner\">${FullName}<\/span>";
strChatLstSupportPartnerTemplate += "            <span class=\"support-item-status partner ${IsOnline}\"><\/span>";
strChatLstSupportPartnerTemplate += "        <\/a>";
strChatLstSupportPartnerTemplate += "    <\/li>";
strChatLstSupportPartnerTemplate += "<\/script>";

var strChatTopBankTemplate = "";
strChatTopBankTemplate += "<script id=\"chat-lst-support-template\" type=\"text\/x-jquery-tmpl\">";
strChatTopBankTemplate += "    <li>";
strChatTopBankTemplate += "        <a href=\"javascript:void(0)\" onclick=\"javascript:BDSChat.initiateChat('${UserId}', '0')\" uid=\"${UserId}\">";
strChatTopBankTemplate += "            <span class=\"support-item-img-partner\">";
strChatTopBankTemplate += "                <img src=\"/Content/Chat/Styles/images/support-partner--topbank-avatar.png\" alt=\"\" title=\"\"><\/span>";
strChatTopBankTemplate += "            <span class=\"support-item-name partner\">${FullName}<\/span>";
strChatTopBankTemplate += "            <span class=\"support-item-status partner ${IsOnline}\"><\/span>";
strChatTopBankTemplate += "        <\/a>";
strChatTopBankTemplate += "    <\/li>";
strChatTopBankTemplate += "<\/script>";

function bindAuthenticateChat() {
    var quickInboxIcon = $('#chat-quick-inbox-icon');
    if (quickInboxIcon.length > 0) {
        quickInboxIcon.css({
        });
        quickInboxIcon.find("img").css("display", "none");
        quickInboxIcon.append("<span class=\"mnu-chat-icon-unread\"></span>");
        var quickInboxContent = $("#pnlQuickBoxChat");
        quickInboxContent.css({
            "top": quickInboxIcon.offset().top + 28,
            "left": quickInboxIcon.offset().left + 2,
        });

        quickInboxIcon.click(function (e) {
            if ($(".chat-quick-inbox-content li").length <= 0) {
                $(".chat-quick-inbox-content").removeClass("active");
            } else {
                $(".chat-quick-inbox-content").toggleClass("active");
            }

            e.stopPropagation();
            return false;
        });

        $(".chat-quick-inbox-content").click(function (e) {
            e.stopPropagation();
            return false;
        });

        $(document).click(function () {
            $(".chat-quick-inbox-content").removeClass("active");
        });
    }
}


function registerChat(userInfo) {
    senderId = userInfo.UserId;
    senderName = userInfo.FullName != null ? userInfo.FullName : userInfo.Name;
    userChatInfo = userInfo;
    senderGender = userInfo.Sex;
    BDSChat.attachEvents();
    BDSChat.setIsAdmin(false);
}
$(document).ready(function () {

    console.log('start connect');
    $.ajax({
        url: '/Chat/ProcessRequest',
        type: 'POST',
        dataType: 'json',
        data: { action: 'getuserinfo' },
        success: function (data) {
            if (data.Data != null) {
                if (!data.Data.IsGuest) bindAuthenticateChat();

                // Connect chat hub
                registerChat(data.Data);
                $('#chat-quick-inbox-content').show();
            } else {
                $('#chat-width-bds-noreg').show();
            }
            // Add emoticons to chat form
            $(document).ready(function () {
                $('.emoticons').allemoticons(emoSetting);
                if ($('.ban_scroll').is(":visible")) {
                    $('.chat-container').css('right', 160);
                    $('#chat-width-bds-noreg').css('right', 160);
                    $('.chat-reg').css('right', 170);
                    var pright = $('#chat-width-bds-noreg').length > 0 ? parseInt($('#chat-width-bds-noreg').css('right'), 10) : parseInt($('.chat-container').css('right'), 10);

                    if ($('.chatPopup').is(':visible')) {
                        pright = parseInt($('.chatPopup').css('right'), 10) + 145
                    }

                    $('#boxProductSaved').css('right', pright + 272);
                    if ($('#boxProductSaved').is(':visible')) {
                        $('.AutoCompare').css('right', parseInt($('#boxProductSaved').css('right'), 10) + 185);
                    }
                    else {
                        $('.AutoCompare').css('right', pright + 272);
                    }


                }
            });
        }
    });


});