// let data = 42;
// let data: any;
let data: number | string; // both

data = '42';

export interface ICar {
    color: string;
    model: string
    topSpeed?: number; // ? makes it optional
}

const car1: ICar = {
    color: 'blue',
    model: 'BMW'
}

const car2: ICar = {
    color: 'yellow',
    model: 'Mercedes',
    topSpeed: 100
}

//const multiply = (x: any, y: any) => {
//    return x*y;
// }

const multiply = (x: number, y: number) => {
    x*y
}

export const cars = [car1, car2];

