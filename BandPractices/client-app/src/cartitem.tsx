import React from 'react'
import { ICar } from './demo'

interface IProps {
    car: ICar
}

const CarItem: React.FC<IProps> = ({car}) => { // instead of props you used cars
    return (
        <div>
            <h4>{car.color}</h4>
        </div>
    )
}

export default CarItem