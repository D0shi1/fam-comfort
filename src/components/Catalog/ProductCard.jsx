import React from "react";
import { useNavigate } from "react-router-dom";

const ProductCard = ({ name, imageUrl }) => {
    const navigate = useNavigate();

    const handleCardClick = () => {
        navigate(`/catalog/facades/${name}`);
    };

    return (
        <div
            className="bg-white border border-gray-300 rounded-lg shadow-md p-4 flex flex-col items-center cursor-pointer transition-transform transform hover:scale-105 hover:shadow-lg"
            onClick={handleCardClick}
        >
            <img
                src={imageUrl}
                alt={name}
                className="w-full h-48 object-cover rounded-md mb-4"
            />
            <h3 className="text-lg font-semibold text-gray-800">{name}</h3>
        </div>
    );
};

export default ProductCard;
