﻿function ProductImagesGrid() {

    var self = new ImagesGridBase();

    self.gridSelector = ".common-files-grid";

    self.getExtraData = function () {
        return { productId: $(".product-id").val() };
    }

    self.init();

    return self;

}