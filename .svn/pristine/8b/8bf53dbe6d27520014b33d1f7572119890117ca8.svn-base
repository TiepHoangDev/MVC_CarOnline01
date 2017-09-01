Foody.Campaign = new function () {
    var self = this;

    function sendGaJcbCard(banks, idx) {

        if (idx < banks.length) {
            ga('ads.send', 'event', 'Bank Card', 'Click', banks[idx].BankName);
            setTimeout(function () {
                sendGaJcbCard(banks, ++idx);
            }, 1000);
        }
    }

    self.GaPushJCBCard = function (banks) {

        if (Math.random() * 100 > 95)return;

        if ($.cookie("bc-jcb") != '1') {
            sendGaJcbCard(banks, 0);
        }

        $.cookie("bc-jcb", '1', { expires: 1 });
    };
};