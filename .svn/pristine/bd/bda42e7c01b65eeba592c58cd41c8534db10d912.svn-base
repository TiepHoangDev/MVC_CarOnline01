
var action = {

    updateStatus: function (choose, id, url) {
        bootbox.confirm({
            title: 'Thông báo',
            message: 'Bạn có muốn cập nhật trạng thái cho Mục này ?',
            buttons: {
                confirm: {
                    label: '<i class="fa fa-check"></i> Có'
                },
                cancel: {
                    label: '<i class="fa fa-times"></i> Không'
                }
            },
            callback: function (result) {
                if (result) {
                    $.ajax({
                        type: 'post',
                        url: url,
                        data: { choose: choose, id: id },
                        dataType: "json",
                        success: function (data) {
                            if (data.rs) {
                                bootbox.alert({
                                    message: "Cập nhật thành công !",
                                    size: 'small',
                                    callback: function () {
                                        window.location.reload();
                                    }
                                });
                            } else {
                                bootbox.alert({
                                    message: "Câp nhật thất bại !",
                                    size: 'small'
                                });
                            }
                        }
                    });
                }
            }
        });
    },

    deleteObject: function (id, url) {
        bootbox.confirm({
            title: "Thông Báo",
            message: 'Bạn có chắc chắn muốn xóa Mục này ?',
            buttons: {
                confirm: {
                    label: '<i class="fa fa-check"></i> Có'
                },
                cancel: {
                    label: '<i class="fa fa-times"></i> Không'
                }
            },
            callback: function (result) {
                if (result) {
                    $.ajax({
                        type: 'post',
                        url: url,
                        data: { id: id },
                        dataType: "json",
                        success: function (data) {
                            if (data.rs) {
                                bootbox.alert({
                                    message: "Xóa thành công !",
                                    size: 'small',
                                    callback: function () {
                                        window.location.reload();
                                    }
                                });
                            } else {
                                bootbox.alert({
                                    message: "Xóa thất bại !",
                                    size: 'small'
                                });
                            }
                        }
                    });
                }
            }
        });
    }
}


