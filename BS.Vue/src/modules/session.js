export default {
    key: "session",
    get() {
        return JSON.parse(localStorage.getItem(this.key));
    },
    set(user) {
        var session = {
            DateAdded: user.DateAdded,
            Email: user.Email,
            FirstName: user.FirstName,
            Id:user.Id,
            IsDeleted:user.IsDeleted,
            LastName: user.LastName,
            Password: user.Password
        };

        localStorage.setItem(this.key, JSON.stringify(session))
    },
    isset() {
        if (localStorage.getItem(this.key) != null) {
            return true;
        } else {
            return false;
        }
    },
    unset() {
        localStorage.removeItem(this.key);
    }
}