import React from "react";
import { useParams } from "react-router-dom";

const ProductPage = () => {
    const { productName } = useParams();

    return (
        <div className="bg-gray-100 min-h-screen flex flex-col items-center">
            <header className="py-6 w-full">
                <h1 className="text-4xl font-bold text-center mb-6 text-black">
                    Подробности о продукте: {productName}
                </h1>
            </header>
            <main className="container mx-auto px-6 py-10">
                <p className="text-lg">Здесь будут загружены данные о {productName}.</p>
            </main>
        </div>
    );
};

export default ProductPage;
