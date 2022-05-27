interface Mountain{
    name:string;
    height:number
}

let mountains:Array<Mountain> = [
    {name:'Kilimanjaro', height:19341},
    {name:'Everest', height:29029},
    {name:'Denali', height:20310}
];

function findNameOfTallestMountain(mountainArray:Array<Mountain>):string {
    let maxHeight:number = 0;
    let maxName:string = '';
    
    for(let i = 0; i < mountainArray.length; i++){
        if(mountainArray[i].height > maxHeight){
            maxHeight = mountainArray[i].height;
            maxName = mountainArray[i].name;
        }
    }
    
    return maxName;
}

console.log(findNameOfTallestMountain(mountains));

interface Product{
    name:string;
    price:number;
}

let products:Array<Product> = [
    {name:'banana', price:2.00},
    {name:'TV', price:500.99},
    {name:'couch', price:999.99}
]

function calcAverageProductPrice(productArray:Array<Product>):number{
    let totalPrice:number = 0;

    for(let i = 0; i < productArray.length; i++){
        totalPrice = totalPrice + productArray[i].price;
    }

    let averagePrice = totalPrice/productArray.length;

    return averagePrice;
}

console.log(calcAverageProductPrice(products));

interface InventoryItem{
    product:Product;
    quantity:number;
}

let inventory:Array<InventoryItem> = [
    {product:{name:'motor', price:10.00}, quantity:10},
    {product:{name:'sensor', price:12.50}, quantity:4},
    {product:{name:'LED', price:1.00}, quantity:20}
]

function calcInventoryValue(inventory:Array<InventoryItem>):number{
    let totalInventoryValue:number = 0;

    for(let i=0; i< inventory.length; i++){
        let currentTotal:number = inventory[i].quantity * inventory[i].product.price;
        totalInventoryValue = totalInventoryValue + currentTotal;
    }

    return totalInventoryValue;
}

console.log(calcInventoryValue(inventory));