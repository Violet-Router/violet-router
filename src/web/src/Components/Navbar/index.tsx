import { NavLink } from "react-router-dom";

const Navbar = () => {
    const activeSytle = "underline text-gray-500 underline-offset-4";

    return (
        <nav className="flex justify-between items-center fixed 
            z-10 w-full py-5 px-8 text-md font-light top-0">
            <ul className="flex items-center gap-3">
                <li className="font-semibold text-lg">
                    <NavLink to="/">Violet-Router</NavLink>
                </li>
                <li>
                    <NavLink to="/"
                            className={({ isActive}) => (isActive ? activeSytle : undefined)}>
                        All
                    </NavLink>
                </li>
                <li>
                    <NavLink to="/clothing"
                            className={({ isActive}) => (isActive ? activeSytle : undefined)}>
                                Clothing
                    </NavLink>
                </li>
                <li>
                    <NavLink to="/electronics"
                            className={({ isActive}) => (isActive ? activeSytle : undefined)}>
                                Electronics
                    </NavLink>
                </li>
                <li>
                    <NavLink to="/sports"
                            className={({ isActive}) => (isActive ? activeSytle : undefined)}>
                                Sports
                    </NavLink>
                </li>
                <li>
                    <NavLink to="/toys"
                            className={({ isActive}) => (isActive ? activeSytle : undefined)}>
                                Toys
                    </NavLink>
                </li>
                <li>
                    <NavLink to="/books"
                            className={({ isActive}) => (isActive ? activeSytle : undefined)}>
                                Books
                    </NavLink>
                </li>
                <li>
                    <NavLink to="/clearance"
                            className={({ isActive}) => (isActive ? activeSytle : undefined)}>
                                Clearance!
                    </NavLink>
                </li>

            </ul>
        </nav>
    )
 }

export default Navbar;
