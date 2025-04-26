import { Outlet } from "react-router-dom";
import { Header } from "./components/Header/Header";
import { Footer } from "./components/Footer/Footer";
import WarningModal from "./components/Modal/WarningModal";

export const Layout = () => {
  return (
    <div className="min-h-screen flex flex-col">
      <Header />
      <WarningModal />
      <main className="flex-grow">
        <Outlet /> {/* Здесь будут отображаться страницы */}
      </main>
      <Footer />
    </div>
  );
};
