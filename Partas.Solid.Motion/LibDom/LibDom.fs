namespace rec Partas.Solid.Motion.LibDom

open Fable.Core

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AutoFill =
    | `` ``
    | off
    | on

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AutoFillField =
    | ``additional-name``
    | ``address-level1``
    | ``address-level2``
    | ``address-level3``
    | ``address-level4``
    | ``address-line1``
    | ``address-line2``
    | ``address-line3``
    | ``bday-day``
    | ``bday-month``
    | ``bday-year``
    | ``cc-csc``
    | ``cc-exp``
    | ``cc-exp-month``
    | ``cc-exp-year``
    | ``cc-family-name``
    | ``cc-given-name``
    | ``cc-name``
    | ``cc-number``
    | ``cc-type``
    | country
    | ``country-name``
    | ``current-password``
    | ``family-name``
    | ``given-name``
    | ``honorific-prefix``
    | ``honorific-suffix``
    | name
    | ``new-password``
    | ``one-time-code``
    | organization
    | ``postal-code``
    | ``street-address``
    | ``transaction-amount``
    | ``transaction-currency``
    | username

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AlignSetting =
    | center
    | ``end``
    | left
    | right
    | start

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AlphaOption =
    | discard
    | keep

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AnimationPlayState =
    | finished
    | idle
    | paused
    | running

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AnimationReplaceState =
    | active
    | persisted
    | removed

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AppendMode =
    | segments
    | sequence

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AttestationConveyancePreference =
    | direct
    | enterprise
    | indirect
    | none

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AudioContextLatencyCategory =
    | balanced
    | interactive
    | playback

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AudioContextState =
    | closed
    | running
    | suspended

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AuthenticatorAttachment =
    | ``cross-platform``
    | platform

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AuthenticatorTransport =
    | ble
    | hybrid
    | ``internal``
    | nfc
    | usb

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AutoFillAddressKind =
    | billing
    | shipping

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AutoFillBase =
    | `` ``
    | off
    | on

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AutoFillContactField =
    | email
    | tel
    | ``tel-area-code``
    | ``tel-country-code``
    | ``tel-extension``
    | ``tel-local``
    | ``tel-local-prefix``
    | ``tel-local-suffix``
    | ``tel-national``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AutoFillContactKind =
    | home
    | mobile
    | work

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AutoFillCredentialField =
    | webauthn

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AutoFillNormalField =
    | ``additional-name``
    | ``address-level1``
    | ``address-level2``
    | ``address-level3``
    | ``address-level4``
    | ``address-line1``
    | ``address-line2``
    | ``address-line3``
    | ``bday-day``
    | ``bday-month``
    | ``bday-year``
    | ``cc-csc``
    | ``cc-exp``
    | ``cc-exp-month``
    | ``cc-exp-year``
    | ``cc-family-name``
    | ``cc-given-name``
    | ``cc-name``
    | ``cc-number``
    | ``cc-type``
    | country
    | ``country-name``
    | ``current-password``
    | ``family-name``
    | ``given-name``
    | ``honorific-prefix``
    | ``honorific-suffix``
    | name
    | ``new-password``
    | ``one-time-code``
    | organization
    | ``postal-code``
    | ``street-address``
    | ``transaction-amount``
    | ``transaction-currency``
    | username

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AutoKeyword =
    | auto

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AutomationRate =
    | ``a-rate``
    | ``k-rate``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AvcBitstreamFormat =
    | annexb
    | avc

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type BinaryType =
    | arraybuffer
    | blob

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type BiquadFilterType =
    | allpass
    | bandpass
    | highpass
    | highshelf
    | lowpass
    | lowshelf
    | notch
    | peaking

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CSSMathOperator =
    | clamp
    | invert
    | max
    | min
    | negate
    | product
    | sum

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CSSNumericBaseType =
    | angle
    | flex
    | frequency
    | length
    | percent
    | resolution
    | time

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CanPlayTypeResult =
    | `` ``
    | maybe
    | probably

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CanvasDirection =
    | ``inherit``
    | ltr
    | rtl

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CanvasFillRule =
    | evenodd
    | nonzero

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CanvasFontKerning =
    | auto
    | none
    | normal

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CanvasFontStretch =
    | condensed
    | expanded
    | ``extra-condensed``
    | ``extra-expanded``
    | normal
    | ``semi-condensed``
    | ``semi-expanded``
    | ``ultra-condensed``
    | ``ultra-expanded``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CanvasFontVariantCaps =
    | ``all-petite-caps``
    | ``all-small-caps``
    | normal
    | ``petite-caps``
    | ``small-caps``
    | ``titling-caps``
    | unicase

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CanvasLineCap =
    | butt
    | round
    | square

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CanvasLineJoin =
    | bevel
    | miter
    | round

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CanvasTextAlign =
    | center
    | ``end``
    | left
    | right
    | start

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CanvasTextBaseline =
    | alphabetic
    | bottom
    | hanging
    | ideographic
    | middle
    | top

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CanvasTextRendering =
    | auto
    | geometricPrecision
    | optimizeLegibility
    | optimizeSpeed

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ChannelCountMode =
    | ``clamped-max``
    | explicit
    | max

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ChannelInterpretation =
    | discrete
    | speakers

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ClientTypes =
    | all
    | sharedworker
    | window
    | worker

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CodecState =
    | closed
    | configured
    | unconfigured

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ColorGamut =
    | p3
    | rec2020
    | srgb

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ColorSpaceConversion =
    | ``default``
    | none

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CompositeOperation =
    | accumulate
    | add
    | replace

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CompositeOperationOrAuto =
    | accumulate
    | add
    | auto
    | replace

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CompressionFormat =
    | deflate
    | ``deflate-raw``
    | gzip

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CredentialMediationRequirement =
    | conditional
    | optional
    | required
    | silent

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DOMParserSupportedType =
    | [<CompiledName("application/xhtml+xml")>] ApplicationXHtmlXml 
    | [<CompiledName("application/xml")>] ApplicationXml
    | [<CompiledName("image/svg+xml")>]ImageSvgXml
    | [<CompiledName("text/html")>] TextHtml
    | [<CompiledName("text/xml")>] TextXml

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DirectionSetting =
    | `` ``
    | lr
    | rl

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DisplayCaptureSurfaceType =
    | browser
    | monitor
    | window

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DistanceModelType =
    | exponential
    | inverse
    | linear

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DocumentReadyState =
    | complete
    | interactive
    | loading

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DocumentVisibilityState =
    | hidden
    | visible

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type EncodedVideoChunkType =
    | delta
    | key

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type EndOfStreamError =
    | decode
    | network

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type EndingType =
    | native
    | transparent

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type FileSystemHandleKind =
    | directory
    | file

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type FillMode =
    | auto
    | backwards
    | both
    | forwards
    | none

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type FontDisplay =
    | auto
    | block
    | fallback
    | optional
    | swap

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type FontFaceLoadStatus =
    | error
    | loaded
    | loading
    | unloaded

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type FontFaceSetLoadStatus =
    | loaded
    | loading

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type FullscreenNavigationUI =
    | auto
    | hide
    | show

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GamepadHapticActuatorType =
    | vibration

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GamepadHapticEffectType =
    | ``dual-rumble``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GamepadHapticsResult =
    | complete
    | preempted

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GamepadMappingType =
    | `` ``
    | standard
    | ``xr-standard``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GlobalCompositeOperation =
    | color
    | ``color-burn``
    | ``color-dodge``
    | copy
    | darken
    | ``destination-atop``
    | ``destination-in``
    | ``destination-out``
    | ``destination-over``
    | difference
    | exclusion
    | ``hard-light``
    | hue
    | lighten
    | lighter
    | luminosity
    | multiply
    | overlay
    | saturation
    | screen
    | ``soft-light``
    | ``source-atop``
    | ``source-in``
    | ``source-out``
    | ``source-over``
    | xor

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type HardwareAcceleration =
    | ``no-preference``
    | ``prefer-hardware``
    | ``prefer-software``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type HdrMetadataType =
    | smpteSt2086
    | ``smpteSt2094-10``
    | ``smpteSt2094-40``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type HighlightType =
    | ``grammar-error``
    | highlight
    | ``spelling-error``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type IDBCursorDirection =
    | next
    | nextunique
    | prev
    | prevunique

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type IDBRequestReadyState =
    | ``done``
    | pending

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type IDBTransactionDurability =
    | ``default``
    | relaxed
    | strict

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type IDBTransactionMode =
    | readonly
    | readwrite
    | versionchange

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ImageOrientation =
    | flipY
    | ``from-image``
    | none

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ImageSmoothingQuality =
    | high
    | low
    | medium

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type InsertPosition =
    | afterbegin
    | afterend
    | beforebegin
    | beforeend

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type IterationCompositeOperation =
    | accumulate
    | replace

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type KeyFormat =
    | jwk
    | pkcs8
    | raw
    | spki

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type KeyType =
    | ``private``
    | ``public``
    | secret

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type KeyUsage =
    | decrypt
    | deriveBits
    | deriveKey
    | encrypt
    | sign
    | unwrapKey
    | verify
    | wrapKey

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LatencyMode =
    | quality
    | realtime

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LineAlignSetting =
    | center
    | ``end``
    | start

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LockMode =
    | exclusive
    | shared

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MIDIPortConnectionState =
    | closed
    | ``open``
    | pending

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MIDIPortDeviceState =
    | connected
    | disconnected

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MIDIPortType =
    | input
    | output

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MediaDecodingType =
    | file
    | ``media-source``
    | webrtc

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MediaDeviceKind =
    | audioinput
    | audiooutput
    | videoinput

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MediaEncodingType =
    | record
    | webrtc

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MediaKeyMessageType =
    | ``individualization-request``
    | ``license-release``
    | ``license-renewal``
    | ``license-request``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MediaKeySessionClosedReason =
    | ``closed-by-application``
    | ``hardware-context-reset``
    | ``internal-error``
    | ``release-acknowledged``
    | ``resource-evicted``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MediaKeySessionType =
    | ``persistent-license``
    | temporary

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MediaKeyStatus =
    | expired
    | ``internal-error``
    | ``output-downscaled``
    | ``output-restricted``
    | released
    | ``status-pending``
    | usable
    | ``usable-in-future``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MediaKeysRequirement =
    | ``not-allowed``
    | optional
    | required

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MediaSessionAction =
    | nexttrack
    | pause
    | play
    | previoustrack
    | seekbackward
    | seekforward
    | seekto
    | skipad
    | stop

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MediaSessionPlaybackState =
    | none
    | paused
    | playing

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MediaStreamTrackState =
    | ended
    | live

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type NavigationTimingType =
    | back_forward
    | navigate
    | prerender
    | reload

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type NotificationDirection =
    | auto
    | ltr
    | rtl

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type NotificationPermission =
    | ``default``
    | denied
    | granted

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type OffscreenRenderingContextId =
    | ``2d``
    | bitmaprenderer
    | webgl
    | webgl2
    | webgpu

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type OrientationType =
    | ``landscape-primary``
    | ``landscape-secondary``
    | ``portrait-primary``
    | ``portrait-secondary``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type OscillatorType =
    | custom
    | sawtooth
    | sine
    | square
    | triangle

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type OverSampleType =
    | ``2x``
    | ``4x``
    | none

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PanningModelType =
    | HRTF
    | equalpower

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PaymentComplete =
    | fail
    | success
    | unknown

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PermissionName =
    | geolocation
    | notifications
    | ``persistent-storage``
    | push
    | ``screen-wake-lock``
    | ``xr-spatial-tracking``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PermissionState =
    | denied
    | granted
    | prompt

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PlaybackDirection =
    | alternate
    | ``alternate-reverse``
    | normal
    | reverse

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PositionAlignSetting =
    | auto
    | center
    | ``line-left``
    | ``line-right``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PredefinedColorSpace =
    | ``display-p3``
    | srgb

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PremultiplyAlpha =
    | ``default``
    | none
    | premultiply

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PresentationStyle =
    | attachment
    | ``inline``
    | unspecified

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PublicKeyCredentialType =
    | ``public-key``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PushEncryptionKeyName =
    | auth
    | p256dh

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCBundlePolicy =
    | balanced
    | ``max-bundle``
    | ``max-compat``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCDataChannelState =
    | closed
    | closing
    | connecting
    | ``open``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCDegradationPreference =
    | balanced
    | ``maintain-framerate``
    | ``maintain-resolution``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCDtlsTransportState =
    | closed
    | connected
    | connecting
    | failed
    | ``new``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCEncodedVideoFrameType =
    | delta
    | empty
    | key

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCErrorDetailType =
    | ``data-channel-failure``
    | ``dtls-failure``
    | ``fingerprint-failure``
    | ``hardware-encoder-error``
    | ``hardware-encoder-not-available``
    | ``sctp-failure``
    | ``sdp-syntax-error``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCIceCandidateType =
    | host
    | prflx
    | relay
    | srflx

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCIceComponent =
    | rtcp
    | rtp

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCIceConnectionState =
    | checking
    | closed
    | completed
    | connected
    | disconnected
    | failed
    | ``new``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCIceGathererState =
    | complete
    | gathering
    | ``new``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCIceGatheringState =
    | complete
    | gathering
    | ``new``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCIceProtocol =
    | tcp
    | udp

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCIceTcpCandidateType =
    | active
    | passive
    | so

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCIceTransportPolicy =
    | all
    | relay

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCIceTransportState =
    | checking
    | closed
    | completed
    | connected
    | disconnected
    | failed
    | ``new``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCPeerConnectionState =
    | closed
    | connected
    | connecting
    | disconnected
    | failed
    | ``new``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCPriorityType =
    | high
    | low
    | medium
    | ``very-low``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCRtcpMuxPolicy =
    | require

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCRtpTransceiverDirection =
    | inactive
    | recvonly
    | sendonly
    | sendrecv
    | stopped

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCSctpTransportState =
    | closed
    | connected
    | connecting

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCSdpType =
    | answer
    | offer
    | pranswer
    | rollback

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCSignalingState =
    | closed
    | ``have-local-offer``
    | ``have-local-pranswer``
    | ``have-remote-offer``
    | ``have-remote-pranswer``
    | stable

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCStatsIceCandidatePairState =
    | failed
    | frozen
    | ``in-progress``
    | inprogress
    | succeeded
    | waiting

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RTCStatsType =
    | ``candidate-pair``
    | certificate
    | codec
    | ``data-channel``
    | ``inbound-rtp``
    | ``local-candidate``
    | ``media-playout``
    | ``media-source``
    | ``outbound-rtp``
    | ``peer-connection``
    | ``remote-candidate``
    | ``remote-inbound-rtp``
    | ``remote-outbound-rtp``
    | transport

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ReadableStreamReaderMode =
    | byob

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ReadableStreamType =
    | bytes

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ReadyState =
    | closed
    | ended
    | ``open``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RecordingState =
    | inactive
    | paused
    | recording

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ReferrerPolicy =
    | `` ``
    | ``no-referrer``
    | ``no-referrer-when-downgrade``
    | origin
    | ``origin-when-cross-origin``
    | ``same-origin``
    | ``strict-origin``
    | ``strict-origin-when-cross-origin``
    | ``unsafe-url``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RemotePlaybackState =
    | connected
    | connecting
    | disconnected

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RequestCache =
    | ``default``
    | ``force-cache``
    | ``no-cache``
    | ``no-store``
    | ``only-if-cached``
    | reload

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RequestCredentials =
    | ``include``
    | omit
    | ``same-origin``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RequestDestination =
    | `` ``
    | audio
    | audioworklet
    | document
    | embed
    | font
    | frame
    | iframe
    | image
    | manifest
    | ``object``
    | paintworklet
    | report
    | script
    | sharedworker
    | style
    | track
    | video
    | worker
    | xslt

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RequestMode =
    | cors
    | navigate
    | ``no-cors``
    | ``same-origin``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RequestPriority =
    | auto
    | high
    | low

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RequestRedirect =
    | error
    | follow
    | manual

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ResidentKeyRequirement =
    | discouraged
    | preferred
    | required

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ResizeObserverBoxOptions =
    | ``border-box``
    | ``content-box``
    | ``device-pixel-content-box``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ResizeQuality =
    | high
    | low
    | medium
    | pixelated

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ResponseType =
    | basic
    | cors
    | ``default``
    | error
    | opaque
    | opaqueredirect

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ScrollBehavior =
    | auto
    | instant
    | smooth

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ScrollLogicalPosition =
    | center
    | ``end``
    | nearest
    | start

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ScrollRestoration =
    | auto
    | manual

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ScrollSetting =
    | `` ``
    | up

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type SecurityPolicyViolationEventDisposition =
    | enforce
    | report

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type SelectionMode =
    | ``end``
    | preserve
    | select
    | start

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ServiceWorkerState =
    | activated
    | activating
    | installed
    | installing
    | parsed
    | redundant

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ServiceWorkerUpdateViaCache =
    | all
    | imports
    | none

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ShadowRootMode =
    | closed
    | ``open``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type SlotAssignmentMode =
    | manual
    | named

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type SpeechSynthesisErrorCode =
    | ``audio-busy``
    | ``audio-hardware``
    | canceled
    | interrupted
    | ``invalid-argument``
    | ``language-unavailable``
    | network
    | ``not-allowed``
    | ``synthesis-failed``
    | ``synthesis-unavailable``
    | ``text-too-long``
    | ``voice-unavailable``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TextTrackKind =
    | captions
    | chapters
    | descriptions
    | metadata
    | subtitles

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TextTrackMode =
    | disabled
    | hidden
    | showing

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TouchType =
    | direct
    | stylus

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TransferFunction =
    | hlg
    | pq
    | srgb

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type UserVerificationRequirement =
    | discouraged
    | preferred
    | required

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VideoColorPrimaries =
    | bt470bg
    | bt709
    | smpte170m

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VideoEncoderBitrateMode =
    | constant
    | quantizer
    | variable

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VideoFacingModeEnum =
    | environment
    | left
    | right
    | user

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VideoMatrixCoefficients =
    | bt470bg
    | bt709
    | rgb
    | smpte170m

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VideoPixelFormat =
    | BGRA
    | BGRX
    | I420
    | I420A
    | I422
    | I444
    | NV12
    | RGBA
    | RGBX

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VideoTransferCharacteristics =
    | bt709
    | ``iec61966-2-1``
    | smpte170m

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type WakeLockType =
    | screen

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type WebGLPowerPreference =
    | ``default``
    | ``high-performance``
    | ``low-power``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type WebTransportCongestionControl =
    | ``default``
    | ``low-latency``
    | throughput

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type WebTransportErrorSource =
    | session
    | stream

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type WorkerType =
    | classic
    | ``module``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type WriteCommandType =
    | seek
    | truncate
    | write

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type XMLHttpRequestResponseType =
    | `` ``
    | arraybuffer
    | blob
    | document
    | json
    | text

module HeadersInit =

    module U3 =

        [<AllowNullLiteral>]
        [<Interface>]
        type Case2 =
            [<EmitIndexer>]
            abstract member Item: key: string -> string with get, set


