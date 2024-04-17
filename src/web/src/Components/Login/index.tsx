import { useAuth0 } from "@auth0/auth0-react";

const LoginButton = () => {
    const { loginWithRedirect, isAuthenticated } = useAuth0();

    if (isAuthenticated) {
        return null;
    }

    return (
        !isAuthenticated && (
            <div className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded">
                <button onClick={() => loginWithRedirect()}>Log In</button>
            </div>
        )
    );
};

export default LoginButton;
