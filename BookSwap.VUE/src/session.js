export default {
    get() {
        return JSON.parse(localStorage.getItem("user"));
    },
    set(token) {
        var session = {
            displayName: token.user.displayName,
            email: token.user.email,
            phoneNumber: token.user.phoneNumber,
            photoURL: token.user.photoURL,
        };

        localStorage.setItem("user", JSON.stringify(session))
    },
    isset() {
        if (localStorage.getItem("user") != null) {
            return true;
        } else {
            return false;
        }
    },
    unset() {
        localStorage.removeItem("user");
    }
}