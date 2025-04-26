import React, { useState, useEffect } from "react";
import { useLocation } from "react-router-dom";

export default function WarningModal() {
  const [isVisible, setIsVisible] = useState(false);
  const location = useLocation();

  useEffect(() => {
    setIsVisible(true); // Показываем модалку при изменении URL
  }, [location.pathname]); // Следим за сменой маршрута

  return (
    isVisible && (
      <div className="fixed inset-0 flex items-center justify-center bg-black bg-opacity-50 z-50">
        <div className="bg-white p-6 rounded-lg shadow-lg text-center max-w-md">
          <h2 className="text-xl font-bold text-red-600">⚠️ Внимание!</h2>
          <p className="mt-2 text-gray-700">
            Мы рады, что вы зашли к нам! Сайт находится в процессе активной
            разработки, и совсем скоро здесь появится ещё больше полезной
            информации и сервисов. Приносим извенения за доставленные
            неудобства!
          </p>
          <button
            className="mt-4 bg-red-600 text-white px-4 py-2 rounded hover:bg-red-700"
            onClick={() => setIsVisible(false)}
          >
            Понял
          </button>
        </div>
      </div>
    )
  );
}
