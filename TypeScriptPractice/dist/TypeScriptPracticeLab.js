"use strict";
let mountains = [
    { name: 'Kilimanjaro', height: 19341 },
    { name: 'Everest', height: 29029 },
    { name: 'Denali', height: 20310 }
];
function findNameOfTallestMountain(mountainArray) {
    let maxHeight = 0;
    let maxName = '';
    for (let i = 0; i < mountainArray.length; i++) {
        if (mountainArray[i].height > maxHeight) {
            maxHeight = mountainArray[i].height;
            maxName = mountainArray[i].name;
        }
    }
    return maxName;
}
console.log(findNameOfTallestMountain(mountains));
let products = [
    { name: 'banana', price: 2.00 },
    { name: 'TV', price: 500.99 },
    { name: 'couch', price: 999.99 }
];
function calcAverageProductPrice(productArray) {
    let totalPrice = 0;
    for (let i = 0; i < productArray.length; i++) {
        totalPrice = totalPrice + productArray[i].price;
    }
    let averagePrice = totalPrice / productArray.length;
    return averagePrice;
}
console.log(calcAverageProductPrice(products));
let inventory = [
    { product: { name: 'motor', price: 10.00 }, quantity: 10 },
    { product: { name: 'sensor', price: 12.50 }, quantity: 4 },
    { product: { name: 'LED', price: 1.00 }, quantity: 20 }
];
function calcInventoryValue(inventory) {
    let totalInventoryValue = 0;
    for (let i = 0; i < inventory.length; i++) {
        let currentTotal = inventory[i].quantity * inventory[i].product.price;
        totalInventoryValue = totalInventoryValue + currentTotal;
    }
    return totalInventoryValue;
}
console.log(calcInventoryValue(inventory));
