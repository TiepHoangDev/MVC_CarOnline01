/*!
 * ASP.NET SignalR JavaScript Library v2.1.2
 * http://signalr.net/
 *
 * Copyright Microsoft Open Technologies, Inc. All rights reserved.
 * Licensed under the Apache 2.0
 * https://github.com/SignalR/SignalR/blob/master/LICENSE.md
 *
 */

/// <reference path="..\..\SignalR.Client.JS\Scripts\jquery-1.6.4.js" />
/// <reference path="jquery.signalR.js" />
(function ($, window, undefined) {
    /// <param name="$" type="jQuery" />
    "use strict";

    if (typeof ($.signalR) !== "function") {
        throw new Error("SignalR: SignalR is not loaded. Please ensure jquery.signalR-x.js is referenced before ~/signalr/js.");
    }

    var signalR = $.signalR;

    function makeProxyCallback(hub, callback) {
        return function () {
            // Call the client hub method
            callback.apply(hub, $.makeArray(arguments));
        };
    }

    function registerHubProxies(instance, shouldSubscribe) {
        var key, hub, memberKey, memberValue, subscriptionMethod;

        for (key in instance) {
            if (instance.hasOwnProperty(key)) {
                hub = instance[key];

                if (!(hub.hubName)) {
                    // Not a client hub
                    continue;
                }

                if (shouldSubscribe) {
                    // We want to subscribe to the hub events
                    subscriptionMethod = hub.on;
                } else {
                    // We want to unsubscribe from the hub events
                    subscriptionMethod = hub.off;
                }

                // Loop through all members on the hub and find client hub functions to subscribe/unsubscribe
                for (memberKey in hub.client) {
                    if (hub.client.hasOwnProperty(memberKey)) {
                        memberValue = hub.client[memberKey];

                        if (!$.isFunction(memberValue)) {
                            // Not a client hub function
                            continue;
                        }

                        subscriptionMethod.call(hub, memberKey, makeProxyCallback(hub, memberValue));
                    }
                }
            }
        }
    }

    $.hubConnection.prototype.createHubProxies = function () {
        var proxies = {};
        this.starting(function () {
            // Register the hub proxies as subscribed
            // (instance, shouldSubscribe)
            registerHubProxies(proxies, true);

            this._registerSubscribedHubs();
        }).disconnected(function () {
            // Unsubscribe all hub proxies when we "disconnect".  This is to ensure that we do not re-add functional call backs.
            // (instance, shouldSubscribe)
            registerHubProxies(proxies, false);
        });

        proxies['chatServer'] = this.createHubProxy('chatServer'); 
        proxies['chatServer'].client = { };
        proxies['chatServer'].server = {
            blockMessage: function (userId) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["BlockMessage"], $.makeArray(arguments)));
             },

            deleteMessage: function (roomId) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["DeleteMessage"], $.makeArray(arguments)));
             },

            endChat: function (chatMessage) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["EndChat"], $.makeArray(arguments)));
             },

            initiateChat: function (productId, clientToUserId) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["InitiateChat"], $.makeArray(arguments)));
            },
            initiateChatInbox: function (productId, clientToUserId,roomId) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["initiateChatInbox"], $.makeArray(arguments)));
            },
            keepConnected: function () {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["KeepConnected"], $.makeArray(arguments)));
             },

            likeOrDislikeSupporter: function (supporterId, isLike) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["LikeOrDislikeSupporter"], $.makeArray(arguments)));
             },

            logOutSingR: function (clientUserId, isAdmin) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["LogOutSingR"], $.makeArray(arguments)));
             },

            reportSpam: function (roomId) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["ReportSpam"], $.makeArray(arguments)));
             },

            requestHistory: function (roomId, lastTimeStamp) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["RequestHistory"], $.makeArray(arguments)));
             },

            requestInboxRooms: function () {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["RequestInboxRooms"], $.makeArray(arguments)));
             },

            requestOnlineUsers: function () {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["RequestOnlineUsers"], $.makeArray(arguments)));
             },

            requestSendEmail: function (roomId, email) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["RequestSendEmail"], $.makeArray(arguments)));
             },

            requestSupporter: function () {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["RequestSupporter"], $.makeArray(arguments)));
             },

            sendChatMessage: function (userChatMsg) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["SendChatMessage"], $.makeArray(arguments)));
             },

            updateReadMessage: function (roomId) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["UpdateReadMessage"], $.makeArray(arguments)));
            },
            updateReadMessage_Inbox: function (roomId) {
                return proxies['chatServer'].invoke.apply(proxies['chatServer'], $.merge(["UpdateReadMessage_Inbox"], $.makeArray(arguments)));
            }
        };

        return proxies;
    };

    signalR.hub = $.hubConnection("/signalr", { useDefaultPath: false });
    $.extend(signalR, signalR.hub.createHubProxies());

}(window.jQuery, window));