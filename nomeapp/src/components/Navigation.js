import React from 'react';
import { NavLink } from 'react-router-dom';

const Navigation = () => {
    return(
        <div>
            <lu>
                <li><NavLink to="/">Home </NavLink></li>
                <li><NavLink to="/About"> About </NavLink></li>
                <li><NavLink to="/Contact"> Contact</NavLink></li>
            </lu>
        </div>
    );
};

export default Navigation;