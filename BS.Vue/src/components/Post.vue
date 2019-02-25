<template>
    <div class="block comment">
        <h4>Leave A Comment</h4>
        <form action="#">
            <!-- Message -->
            <div class="form-group mb-30">
                <label for="message">Message</label>
                <textarea class="form-control" id="message" rows="8"></textarea>
            </div>
            <div class="row">
                <div class="col-sm-12 col-md-6">
                    <!-- Name -->
                    <div class="form-group mb-30">
                        <label for="name">Name</label>
                        <input type="text" class="form-control" id="name">
                    </div>
                </div>
                <div class="col-sm-12 col-md-6">
                    <!-- Email -->
                    <div class="form-group mb-30">
                        <label for="email">Email</label>
                        <input type="email" class="form-control" id="email">
                    </div>
                </div>
            </div>
            <button class="btn btn-transparent">Leave Comment</button>
        </form>
    </div>
</template>

<script>
    export default {

    }
</script>

<style scoped>
</style>