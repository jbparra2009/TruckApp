new Cleave('.account', {
    prefix: 'IEAT',
    delimiter: '-',
    blocks: [4, 4],
    uppercase: true
});
new Cleave('.donation', {
    numeral: true,
    numeralThousandGroupStyle: 'thousand'
});
var cleave = new Cleave('.phone', {
    phone: true,
    phoneRegionCode: 'us'
});

//new Cleave('.account', {
//    prefix: 'IEAT',
//    delimiter: '-',
//    blocks: [4, 4],
//    uppercase: true
//});
//new Cleave('.donation', {
//    numeral: true,
//    numeralThousandGroupStyle: 'thousand'
//})

//new Cleave('.creditcard', {
//    creditCard: true,
//    delimiter: '-',
//    onCreditCardTypeChanged: function (type) {
//        if (type === 'visa') {
//            document.querySelector('.fa-cc-visa').classList.add('active');
//        } else {
//            document.querySelector('.fa-cc-visa').classList.remove('active');
//        }
//    }
//});