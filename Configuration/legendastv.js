define(['loading', 'emby-input', 'emby-button'], function (loading) {
    'use strict';

    function loadPage(page, config) {

        page.querySelector('#txtUsername').value = config.LegendasTVUsername || '';
        page.querySelector('#txtPassword').value = config.LegendasTVPasswordHash || '';

        loading.hide();
    }

    function onSubmit(e) {

        e.preventDefault();

        loading.show();

        var form = this;

        ApiClient.getNamedConfiguration("legendastv").then(function (config) {

            config.LegendasTVUsername = form.querySelector('#txtUsername').value;

            var newPassword = form.querySelector('#txtPassword').value;

            if (newPassword) {
                config.LegendasTVPasswordHash = newPassword;
            }


            ApiClient.updateNamedConfiguration("legendastv", config).then(Dashboard.processServerConfigurationUpdateResult);
        });

        // Disable default form submission
        return false;
    }

    function getConfig() {

        return ApiClient.getNamedConfiguration("legendastv").then(function (config) {

            if (config.LegendasTVUsername || config.LegendasTVPasswordHash) {
                return config;
            }

            return ApiClient.getNamedConfiguration("legendastv");
        });
    }

    return function (view, params) {

        view.querySelector('form').addEventListener('submit', onSubmit);

        view.addEventListener('viewshow', function () {

            loading.show();

            var page = this;

            getConfig().then(function (response) {

                loadPage(page, response);
            });
        });
    };

});
