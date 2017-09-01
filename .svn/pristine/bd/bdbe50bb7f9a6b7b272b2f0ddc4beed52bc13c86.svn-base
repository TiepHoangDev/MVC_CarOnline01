String.format = function () {
    // The string containing the format items (e.g. "{0}")
    // will and always has to be the first argument.
    var theString = arguments[0];

    // start with the second argument (i = 1)
    for (var i = 1; i < arguments.length; i++) {
        // "gm" = RegEx options for Global search (more than one instance)
        // and for Multiline search
        var regEx = new RegExp("\\{" + (i - 1) + "\\}", "gm");
        theString = theString.replace(regEx, arguments[i]);
    }

    return theString;
}
var arrVerb_old = ['Bán', 'Cần bán xe,Bán xe,Cần bán gấp,Cần bán lại xe,Bán ô tô,Xe,Cần bán'];
var arrVerb_old_Percent = [0.3, 0.7];

var arrVerb_new = ['Bán', 'Bán xe,Bán ô tô,Cần bán,Cần bán xe'];
var arrVerb_new_Percent = [0.3, 0.7];

var arrYear = [' đời ', ' năm ', ' sản xuất ', ' '];
var weightYear = [0.7, 0.1, 0.1, 0.1];

var arrYearReg = ['đăng ký', 'đăng ký lần đầu'];

var arrDes_old = ['chính chủ', 'còn mới', 'xe gia đình', 'số tự động', 'số sàn', 'như mới', 'đẹp như mới', 'ít sử dụng', 'mới chạy\\s?[\\w\\.?]+\\s?km', 'đã đi\\s?[\\w\\.?]+\\s?km', 'mới\\s?[0-9]{1,3}%'];
var arrDes_new = ['mới\\s?[0-9]{1,3}%'];

var arrImportFrom = ['nhập từ Thái', 'nhập khẩu Thái', 'nhập khẩu Thái Lan', 'nhập khẩu Hàn Quốc', 'nhập khẩu Nhật Bản', 'nhập từ Nhật', 'nhập từ Đức', 'nhập từ Mĩ'];
var arrImport = [', xe nhập', ', nhập khẩu', ', nhập khẩu nguyên chiếc'];

var arrPrice = [', giá {0}tr', ', {0}tr', ', {0} triệu', ', giá chỉ {0} triệu', ', giá tốt', ' giá cạnh tranh'];


function FormatPrice(price) {
    price = eval(price) * 1000000;

    if (price > 1000000000 || price == 0) {
        //var strReturnStart = Math.floor(price / 1000000000) + " tỷ";
        //var strReturnEnd = (Math.round(price % 1000000000, 0) / 1000000) + "";
        //if (strReturnEnd == "0") return " giá " + strReturnStart;
        //else return " giá " + strReturnStart + " " + Math.round(strReturnEnd) + " triệu";
        return "";
    }
    else return String.format(arrPrice[Math.floor(Math.random() * arrPrice.length)], price / 1000000);
}
function processModel(make, model) {
    make = make.toLowerCase() == 'mercedes-benz' ? 'Mercedes' : make;
    var result = make != "" ? " " + make : "";
    if (make.toLowerCase() != 'mercedes') {
        result += model != "" ? " " + model : "";
    }
    return result;
}
var rand = function (min, max) {
    return Math.random() * (max - min) + min;
};

var randWeighedList = function (min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
};

var getRandomItem = function (list, weight) {
    var total_weight = weight.reduce(function (prev, cur, i, arr) {
        return prev + cur;
    });

    var random_num = rand(0, total_weight);
    var weight_sum = 0;
    //console.log(random_num)     
    for (var i = 0; i < list.length; i++) {
        weight_sum += weight[i];
        weight_sum = +weight_sum.toFixed(2);

        if (random_num <= weight_sum) {
            return list[i];
        }
    }
    // end of function
};

var generateWeighedList = function (list, weight) {
    var weighed_list = [];

    // Loop over weights
    for (var i = 0; i < weight.length; i++) {
        var multiples = weight[i] * 100;

        // Loop over the list of items
        for (var j = 0; j < multiples; j++) {
            weighed_list.push(list[i]);
        }
    } 
    var random_num = randWeighedList(0, weighed_list.length - 1);
    return weighed_list[random_num];
};


function GenerateTitle(numOfKm, secondHand, desc, make, model, modelDetail, year, color, price, madeIn) {
    // fixed   
    var arrDes = [];
    var arrVerb = [];
    var str = '';
    if (secondHand == "1") {        
        var title = generateWeighedList(arrVerb_old, arrVerb_old_Percent);
        if (title.length > 3 && title.indexOf(',') > 0) {
            var oldArrVerb = title.split(',');
            str = oldArrVerb[Math.floor(Math.random() * oldArrVerb.length)]
        }
        else {
            str = title;
        }

        arrDes = arrDes_old;
    }
    else {
        var title = generateWeighedList(arrVerb_new, arrVerb_new_Percent);
        if (title.length > 3 && title.indexOf(',') > 0)
        {
            var newArrVerb = title.split(',');
            str = newArrVerb[Math.floor(Math.random() * newArrVerb.length)]
        }
        else
        {
            str = title;
        }
        
        arrDes = arrDes_new;

    }

   // var str = arrVerb[Math.floor(Math.random() * arrVerb.length)];    

    str += processModel(make, model);

    str += modelDetail != "" ? " " + modelDetail : "";

    str += getRandomItem(arrYear, weightYear) + year;

    if (color != "") {

        color = color.indexOf('màu') != -1 ? ", " + color.toLowerCase() : ", màu " + color.toLowerCase();
        color = color.indexOf('khác') != -1 ? "" : color;
        str += color != "" ? color : "";
    }

    if (madeIn == "2") {
        var strMadeIn = getKeywordInContent(desc, arrImportFrom);
        if (strMadeIn == "") {
            strMadeIn = arrImport[Math.floor(Math.random() * arrImport.length)];
            str += strMadeIn;
        }
        else {
            str += ", " + strMadeIn;
        }

    }

    var description = getKeywordInContent(desc, arrDes).toLowerCase();

    str += description != "" ? " " + description : "";

    var random = Math.random();
    if (random < 0.5) {
        str += FormatPrice(price);
    }

    return str;
}

function getKeywordInContent(content, array) {
    var arrTmp = [];
    $.each(array, function (j) {
        var rSearchTerm = new RegExp(array[j], 'ig');
        var matchStr = rSearchTerm.exec(content);
        if (matchStr != null) {
            arrTmp.push(matchStr[0]);
        }
    });

    return arrTmp.length > 0 ? arrTmp[Math.floor(Math.random() * arrTmp.length)] : "";
}
function SetTitle() {
    var str = $("#spanGoiytieude").text();
    var loca = $.trim($("#Title").val());

    $("#Title").replaceAll(loca, '');
    $("#Title").val(str);
    $("#vip-preview-title").text(str);
    $('#dvSuggesTitle').hide();
}